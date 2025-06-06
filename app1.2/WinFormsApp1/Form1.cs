using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Data.Data data;
        public Form1()
        {
            InitializeComponent();
            data = new Data.Data();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();

            // Валидация данных

            if (string.IsNullOrEmpty(products.Text))
            {
                MessageBox.Show("Товар не выбран!");
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Выберите способ оплаты");
                return;
            }

            string[] selected_products = new string[selectedProducts.Items.Count];
            int[] nums = new int[selectedProducts.Items.Count];

            for (int i = 0; i < selected_products.Length; i++)
            {
                string item = selectedProducts.Items[i]!.ToString()!;
                var (product, num) = ParseProductInfo(item);
                selected_products[i] = product;
                nums[i] = num;
            }

            string client = clients.Text;
            string payment = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            int total_sum = Convert.ToInt32(totalSum.Text);

            data.createOrder(date, client, total_sum, selected_products, nums);
            Data.ExcelHelper.SaveDataTableToExcel(data.getAllClientDeliveries(client), "Накладная");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(products.Text))
            {
                MessageBox.Show("Товар не выбран!");
                return;
            }

            string product = products.Text;
            string num = numProducts.Value.ToString();
            input_Product(product, num);
            totalSum.Text = TotalSum().ToString();
        }

        int TotalSum()
        {
            int sum = 0;

            for (int i = 0; i < selectedProducts.Items.Count; i++)
            {
                string item = selectedProducts.Items[i]!.ToString()!;

                if (int.TryParse(item.Split(new[] { " - ", " штук" }, StringSplitOptions.RemoveEmptyEntries)[1], out int num))
                {
                    int lastSeparatorIndex = item.LastIndexOf(" - ");
                    string product = item.Substring(0, lastSeparatorIndex).Trim();
                    sum += num * data.priceOfProducts(product);
                }
            }
            return sum;
        }

        (string ProductName, int Quantity) ParseProductInfo(string input)
        {
            int lastSeparatorIndex = input.LastIndexOf(" - ");
            string productName = input.Substring(0, lastSeparatorIndex).Trim();
            string quantityPart = input.Substring(lastSeparatorIndex + 3).Trim();
            Match match = Regex.Match(quantityPart, @"\d+");

            if (!match.Success || !int.TryParse(match.Value, out int quantity) || quantity <= 0)
            {
                throw new FormatException("Не удалось распарсить количество товара или оно некорректно");
            }

            return (productName, quantity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var del_item = selectedProducts.SelectedItem;

            if (del_item != null)
            {
                selectedProducts.Items.Remove(del_item);
                totalSum.Text = TotalSum().ToString();
            }
            else
            {
                return;
            }
        }

        void input_Product(string product, string num)
        {
            bool productFound = false;

            for (int i = 0; i < selectedProducts.Items.Count; i++)
            {
                string item = selectedProducts.Items[i]!.ToString()!;

                if (item.StartsWith(product + " - "))
                {
                    productFound = true;

                    if (int.TryParse(item.Split(new[] { " - ", " штук" }, StringSplitOptions.RemoveEmptyEntries)[1], out int oldQuantity))
                    {
                        // Обновляем количество
                        int newQuantity = oldQuantity + int.Parse(num);
                        selectedProducts.Items[i] = $"{product} - {newQuantity} штук";
                    }
                    break;
                }
            }

            // Если товар не найден, добавляем новый
            if (!productFound)
            {
                selectedProducts.Items.Add($"{product} - {num} штук");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clients.Text))
            {
                MessageBox.Show("Клиент не выбран!");
                return;
            }
            choice.Visible = false;
            clientTabs.Visible = true;
            exit.Visible = true;
            clients.Visible = false;
            label1.Text = clients.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!deliveryTable.Visible)
            {
                return;
            }
            foreach (DataGridViewRow row in deliveryTable.Rows)
            {


                if (row.Cells["is_delivered"].Value.ToString() == "True")
                {
                    //string date = dateTimePicker2.Value.ToShortDateString();
                    int order_id = Convert.ToInt32((row.Cells["order_id"].Value.ToString()));
                    string product = row.Cells["product_name"].Value!.ToString()!;
                    data.updateStatusProduct(order_id, product);
                    updatDevTable();
                }
            }

        }

        void updatDevTable()
        {
            string client = clients.Text;
            DataTable dt = new DataTable();
            dt = data.getAllClientDeliveries(client);
            if (dt.Rows.Count > 0)
            {
                deliveryTable.DataSource = dt;
            }
            else
            {
                deliveryTable.Visible = false;
                MessageBox.Show("У вас пока нет ожидаемых доставок!");
            }
        }

        private void clientTabs_Click(object sender, EventArgs e)
        {



            int select_index_tab = clientTabs.SelectedIndex;

            switch (select_index_tab)
            {
                case 1:
                    updatDevTable();
                    break;
                case 2:
                    displayClientOrders(clients.Text);
                    break;
                case 3:
                    displayClientInfo(clients.Text);
                    break;
            }
        }

        void displayClientInfo(string clientName)
        {

            DataTable dataTable = data.getClientInfo(clientName);
            DataRow row = dataTable.Rows[0];
            id_client.Text = $"Клиент№{row["id"]?.ToString()}";
            name_client.Text = $"Имя: {row["name"]?.ToString()}";
            info_client.Text = $"Контакты: {row["contact_info"]?.ToString()}";

        }

        void displayClientOrders(string clientName)
        {
            DataTable dt = new DataTable();
            dt = data.getClientOrders(clientName);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("У вас пок анет заказов!");
                clientOrders.Visible = false;
                return;
            }
            clientOrders.Visible = true;
            clientOrders.DataSource = dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            clientTabs.Visible = false;
            exit.Visible = false;
            label1.Text = "Для начала работы выберите \r\nклиента\r\n";
            clients.Visible = true;
            choice.Visible = true;

        }

        private void adminTabs_Click(object sender, EventArgs e)
        {
            int select_index_tab = adminTabs.SelectedIndex;

            switch (select_index_tab)
            {
                case 1:
                    allProductsTable.DataSource = data.getInfoAbout("products");
                    break;
                case 2:
                    allOrdersTable.DataSource = data.getInfoAbout("orders");
                    break;
                case 3:
                    allClientsTable.DataSource = data.getInfoAbout("clients");
                    break;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string dateStart = dateTimePicker3.Value.ToShortDateString();
            string dateEnd = dateTimePicker4.Value.ToShortDateString();
            DataTable dataTable = new DataTable();
            dataTable = data.getReport(dateStart, dateEnd);
            reportTable.DataSource = dataTable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (reportTable.DataSource is DataTable table)
            {
                Data.ExcelHelper.SaveDataTableToExcel(table);
            }
            else
            {
                MessageBox.Show("Отчет не сформирован!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dateStart = dateTimePicker6.Value.ToShortDateString();
            string dateEnd = dateTimePicker5.Value.ToShortDateString();
            DataTable dt = new DataTable();

            List<int> clientsId = new List<int>();

            System.Windows.Forms.CheckBox[] checkBoxes = new System.Windows.Forms.CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    int clientId = int.Parse(checkBox.Name.Replace("checkBox", ""));
                    clientsId.Add(clientId);
                }
            }



            dt = data.getReport2(clientsId,dateStart, dateEnd);
            chart1.Visible = true;
            // Очищаем существующие серии и области
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Добавляем область для диаграммы
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Настраиваем серии
            Series seriesOrders = new Series("Сумма заказов");
            seriesOrders.ChartType = SeriesChartType.Column;
            seriesOrders.XValueMember = "day"; // Ось X: дата
            seriesOrders.YValueMembers = "total_orders"; // Ось Y: заказы

            Series seriesDeliveries = new Series("Сумма доставок");
            seriesDeliveries.ChartType = SeriesChartType.Column;
            seriesDeliveries.XValueMember = "day";
            seriesDeliveries.YValueMembers = "total_deliveries";

            // Добавляем серии на диаграмму
            chart1.Series.Add(seriesOrders);
            chart1.Series.Add(seriesDeliveries);

            // Привязываем данные
            chart1.DataSource = dt;
            chart1.DataBind();

            // Настраиваем отображение дат на оси X
            chartArea.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartArea.AxisX.Interval = 1;
            seriesOrders.Color = Color.Red;
            seriesDeliveries.Color = Color.Green;
            // Добавляем легенду
            chart1.Legends.Add(new Legend());


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string priceText = textBox2.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Имя продукта не может быть пустым.");
                return;
            }

          
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную положительную цену.");
                return;
            }

            data.InsertProductToDatabase(name, price);
            textBox1.Text = "";
            textBox2.Text = "";
            RefreshDataGrid();
            MessageBox.Show("Продукт успешно добавлен ");


        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (allProductsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар для изменения.");
                return;
            }

            var selectedRow = allProductsTable.SelectedRows[0];

            int productId = Convert.ToInt32(selectedRow.Cells["Идентификатор товара"].Value);

            string newName = textBox1.Text.Trim();
            string priceText = textBox2.Text.Trim(); 

            
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Имя продукта не может быть пустым.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal newPrice) || newPrice <= 0)
            {
                MessageBox.Show("Введите корректную положительную цену.");
                return;
            }
            data.UpdateProduct(productId, newName, newPrice);
            textBox1.Text = "";
            textBox2.Text = "";
            RefreshDataGrid();
            MessageBox.Show($"Продукт {productId} был успешно изменен! ");

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (allProductsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар для удаления.");
                return;
            }

            var selectedRow = allProductsTable.SelectedRows[0];
            int productId = Convert.ToInt32(selectedRow.Cells["Идентификатор товара"].Value);

            var confirmResult = MessageBox.Show(
                "Вы уверены, что хотите удалить этот товар?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                data.DeleteProduct(productId);
                RefreshDataGrid();
                MessageBox.Show($"Продукт {productId} был успешно удален! ");
            }
        }


        private void RefreshDataGrid()
        {
            allProductsTable.DataSource = data.getInfoAbout("products");
        }
    }
}
