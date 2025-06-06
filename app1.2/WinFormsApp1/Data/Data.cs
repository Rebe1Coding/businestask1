using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WinFormsApp1.Data
{
    class Data
    {
        public Data()
        {
            con = new NpgsqlConnection(connString);
        }

        private readonly string connString = "Host=127.0.0.1;Username=postgres;Password=1234;Database=onlineStore";
        NpgsqlConnection con;

        private readonly string clientsQuery = @"
                            SELECT 
                                id AS ""Идентификатор клиента"",
                                name AS ""Имя клиента"",
                                contact_info AS ""Контактная информация""
                            FROM clients";

        private readonly string productsQuery = @"
                                        SELECT 
                                            id AS ""Идентификатор товара"",
                                            name AS ""Название товара"",
                                            price AS ""Цена""
                                        FROM products";

        string ordersQuery = @"
                                    SELECT 
                                        id AS ""Номер заказа"",
                                        client_id AS ""Идентификатор клиента"",
                                        order_date AS ""Дата заказа"",
                                    CASE 
                                    WHEN is_active THEN 'Активный' 
                                                    ELSE 'Завершен' 
                                                END AS ""Статус заказа""
                                                    FROM orders";
        public DataTable getInfoAbout(string name)
        {
            string query = name switch
            {
                "products" => productsQuery,
                "orders" => ordersQuery,
                "clients" => clientsQuery,
                _ => throw new ArgumentException($"Неизвестное имя: {name}")
            };

            DataTable dt = new DataTable();
            OpenConnection();
            try
            {
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con);
                adap.Fill(dt);
            }
            catch (Exception ex) { 
            
            MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return dt;

        }


        public DataTable getReport(string startDate, string endDate)
        {
            string query = @"
        SELECT 
            p.id AS ""Идентификатор_товара"",
            p.name AS ""Название_товара"",
            COUNT(DISTINCT o.id) AS ""Количество_заказов"",
            COALESCE(SUM(oi.quantity), 0) AS ""Всего_заказано"",
            COALESCE(SUM(CASE WHEN oi.is_delivered THEN oi.quantity ELSE 0 END), 0) AS ""Доставлено"",
            COALESCE(SUM(oi.quantity * p.price), 0) AS ""Сумма_заказов"",
            COALESCE(SUM(CASE WHEN oi.is_delivered THEN oi.quantity * p.price ELSE 0 END), 0) AS ""Сумма_доставок""
        FROM 
            products p
        LEFT JOIN 
            order_items oi ON p.id = oi.product_id
        LEFT JOIN 
            orders o ON oi.order_id = o.id 
                AND o.order_date BETWEEN TO_DATE(@startDate,'DD.MM.YYYY') AND TO_DATE(@endDate,'DD.MM.YYYY')
        GROUP BY 
            p.id, p.name
        ORDER BY 
            ""Сумма_заказов"" DESC;";

            DataTable dt = new DataTable();

            OpenConnection();
            try
            {
                using (var command = new NpgsqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(dt);

                }
            }
            catch(Exception ex) {
                MessageBox.Show($"Что пошло не так!{ex.Message}");

            }
            CloseConnection() ;
            return dt;
        }
        public DataTable getReport2(List<int> clientIds,string startDate, string endDate)
        {
            string query = @"
        SELECT 
            COALESCE(orders_data.day, deliveries_data.day) AS day,
            COALESCE(orders_data.total_orders, 0) AS total_orders,
            COALESCE(deliveries_data.total_deliveries, 0) AS total_deliveries
        FROM 
            (SELECT 
                DATE(o.order_date) AS day,
                SUM(o.total_amount) AS total_orders
             FROM orders o
             WHERE 
                o.client_id =  ANY(@clientIds)
                AND o.order_date BETWEEN TO_DATE(@startDate,'DD.MM.YYYY') AND TO_DATE(@endDate,'DD.MM.YYYY')
             GROUP BY day) AS orders_data
        FULL OUTER JOIN 
            (SELECT 
                DATE(o.order_date) AS day,
                SUM(p.price * oi.quantity) AS total_deliveries
             FROM order_items oi
             JOIN orders o ON oi.order_id = o.id
             JOIN products p ON oi.product_id = p.id
             WHERE 
                o.client_id = ANY(@clientIds)
                AND oi.is_delivered = TRUE
                AND o.order_date BETWEEN TO_DATE(@startDate,'DD.MM.YYYY') AND TO_DATE(@endDate,'DD.MM.YYYY')
             GROUP BY day) AS deliveries_data
        ON orders_data.day = deliveries_data.day
        ORDER BY day;";

            DataTable dt = new DataTable();

            OpenConnection();
            try
            {
                using (var command = new NpgsqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    command.Parameters.AddWithValue("@clientIds", clientIds);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что пошло не так!{ex.Message}");

            }
            CloseConnection();
            return dt;
        }


        public DataTable getClientInfo(string name)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM clients WHERE name = @name";
            OpenConnection();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                using(NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd))
                {
                    adap.Fill(dt);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что пошло не так!{ex.Message}");

            }
            CloseConnection();
            return dt;

        }
        public DataTable getAllProducts()
        {
            string query = "SELECT * FROM products";
            DataTable dt = new DataTable();
            OpenConnection();
            try
            {
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что пошло не так!{ex.Message}");
            }
            CloseConnection();
            return dt;
        }



        public int priceOfProducts(string name)
        {
            string query = "SELECT price FROM products WHERE name = @name";
            DataTable dt = new DataTable();

            OpenConnection();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            CloseConnection();
            return Convert.ToInt32(dt.Rows[0]["price"]);
        }
        public DataTable getAllClients()
        {
            string query = "SELECT * FROM clients";
            DataTable dt = new DataTable();
            OpenConnection();
            try
            {
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что пошло не так!{ex.Message}");
            }
            CloseConnection();
            return dt;
        }
        void OpenConnection()
        {
            try
            {
                if (con != null && con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии соединения: {ex.Message}");
            }
        }


        void CloseConnection()
        {
            try
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при закрытии соединения: {ex.Message}");
            }
        }

        public void createOrder(string date, string client, int sum, string[] products, int[] nums)
        {
            int clientId = getClientId(client);
            string orderQuery = @"
                INSERT INTO orders(client_id, order_date, total_amount) 
                VALUES (@client_id, TO_DATE(@order_date,'DD.MM.YYYY'), @total_amount)
                RETURNING id;";


            OpenConnection();
            using (var transaction = con.BeginTransaction()) // Используем using для транзакции
            {
                try
                {
                    int orderId;

                    using (var orderCommand = new NpgsqlCommand(orderQuery, con, transaction))
                    {
                        
                        orderCommand.Parameters.AddWithValue("@client_id", clientId);
                        orderCommand.Parameters.AddWithValue("@order_date", date);
                        orderCommand.Parameters.AddWithValue("@total_amount", sum);

                        orderId = Convert.ToInt32(orderCommand.ExecuteScalar());
                    }

                    // Добавление позиций заказа
                    addOrderItems(orderId, products, nums, transaction);

                    transaction.Commit(); 
                    MessageBox.Show("Заказ успешно создан!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); 
                    MessageBox.Show($"Ошибка: {ex.Message}\nВсе изменения отменены!");
                }
                finally
                {
                    CloseConnection(); 
                }
            }
        }

        private void addOrderItems(int orderId, string[] products, int[] nums, NpgsqlTransaction transaction)
        {
            string itemsQuery = @$"INSERT INTO order_items(order_id, product_id, quantity) 
                                    VALUES (@order_id, @product_id, @quantity)";

            for (int i = 0; i < products.Length; i++)
            {
                int productId = getProductId(products[i], transaction); 

                using (var itemCommand = new NpgsqlCommand(itemsQuery, con, transaction))
                {
                    itemCommand.Parameters.AddWithValue("@order_id", orderId);
                    itemCommand.Parameters.AddWithValue("@product_id", productId);
                    itemCommand.Parameters.AddWithValue("@quantity", nums[i]);

                    itemCommand.ExecuteNonQuery();
                }
            }
        }

   
        int getClientId(string clientName)
        {
            string query = "SELECT id FROM clients WHERE name = @name";
            OpenConnection();

            using (var cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", clientName);
                var result = cmd.ExecuteScalar();
                if (result == null)
                    throw new Exception($"Клиент '{clientName}' не найден");
                CloseConnection();
                return Convert.ToInt32(result);
            }
            
        }

        int getProductId(string productName, NpgsqlTransaction transaction)
        {
            string query = "SELECT id FROM products WHERE name = @name";
            using (var cmd = new NpgsqlCommand(query, con, transaction))
            {
                cmd.Parameters.AddWithValue("@name", productName);
                var result = cmd.ExecuteScalar();
                if (result == null)
                    throw new Exception($"Продукт '{productName}' не найден");
                return Convert.ToInt32(result);
            }
        }


        public DataTable getAllClientDeliveries(string client)
        {


            string query = @$"SELECT 
                        o.id AS order_id,
                        p.name AS product_name,
                        oi.quantity,
                        oi.is_delivered,
                        o.order_date
                    FROM 
                        clients c
                    JOIN 
                        orders o ON c.id = o.client_id
                    INNER JOIN 
                        order_items oi ON o.id = oi.order_id AND oi.is_delivered = false
                    LEFT JOIN 
                        products p ON oi.product_id = p.id
                    WHERE 
                        c.id = {getClientId(client)}";
            
            DataTable dt = new DataTable();
            OpenConnection();
            try
            {
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(query, con);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что пошло не так!{ex.Message}");
            }
            CloseConnection();
            return dt;
        }


        public void updateStatusProduct(int order_id, string product)
        {

            string query = @$"UPDATE order_items
                                SET is_delivered = true 
                            WHERE 
                                order_id = @order_id 
                            AND product_id = @id;";
            OpenConnection();
            using (var transaction = con.BeginTransaction())
            {
                
                try
                {
                    using (var cmd = new NpgsqlCommand(query, con, transaction))
                    {
                        int productId = getProductId(product, transaction);
                        cmd.Parameters.AddWithValue("order_id", order_id);
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Что то пошло не так!{ex.Message}");
                }
                finally { 
                CloseConnection();
                }
            }

        }

        public DataTable getClientOrders(string clientName)
        {
            string query = @"
                        SELECT 
                        id as ""Номер заказа"",
                        order_date as ""Дата"",
                        CASE 
                             WHEN is_active THEN 'Активный' 
                             ELSE 'Завершен' 
                            END AS ""Статус""
                            FROM orders 
                            WHERE client_id = @client_id";
            DataTable dt = new DataTable();
            int clientId= getClientId(clientName);
            OpenConnection();
            try {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@client_id", clientId);
                    NpgsqlDataAdapter adap = new NpgsqlDataAdapter(cmd);
                    adap.Fill(dt);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что то пошло не так{ex.Message}!");
            }
            CloseConnection();
            return dt;
            

        }

        public void InsertProductToDatabase(string name, decimal price)
        {
            string query = "INSERT INTO products (name, price) VALUES (@name, @price)";

            OpenConnection();
            try
            {
                
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("price", price);

                        cmd.ExecuteNonQuery();
                    }
                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Ошибка при добавлении продукта: {ex.Message}");
                
            }
            CloseConnection();
        }


        public void UpdateProduct(int id, string name, decimal price)
        {
            var query = "UPDATE products SET name = @name, price = @price WHERE id = @id";

            OpenConnection();
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            CloseConnection();
            
        }

        // Удаление продукта
        public void DeleteProduct(int id)
        {
            var query = "DELETE FROM products WHERE id = @id";

            OpenConnection();
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
