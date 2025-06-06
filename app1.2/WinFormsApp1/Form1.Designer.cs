namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mainTabs = new TabControl();
            adminPart = new TabPage();
            adminTabs = new TabControl();
            profile = new TabPage();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            allProducts = new TabPage();
            label9 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            allProductsTable = new DataGridView();
            allOrders = new TabPage();
            allOrdersTable = new DataGridView();
            allClients = new TabPage();
            allClientsTable = new DataGridView();
            reports = new TabPage();
            reportsTabs = new TabControl();
            report1 = new TabPage();
            button6 = new Button();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            reportTable = new DataGridView();
            report2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button8 = new Button();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            clientPart = new TabPage();
            panel1 = new Panel();
            exit = new Button();
            choice = new Button();
            label1 = new Label();
            clients = new ComboBox();
            clientTabs = new TabControl();
            orderCreate = new TabPage();
            totalSum = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button3 = new Button();
            numProducts = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            selectedProducts = new ListBox();
            products = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            deliveryList = new TabPage();
            button5 = new Button();
            dateTimePicker2 = new DateTimePicker();
            deliveryTable = new DataGridView();
            orders = new TabPage();
            clientOrders = new DataGridView();
            info = new TabPage();
            pictureBox2 = new PictureBox();
            info_client = new Label();
            name_client = new Label();
            id_client = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            mainTabs.SuspendLayout();
            adminPart.SuspendLayout();
            adminTabs.SuspendLayout();
            profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            allProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allProductsTable).BeginInit();
            allOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allOrdersTable).BeginInit();
            allClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allClientsTable).BeginInit();
            reports.SuspendLayout();
            reportsTabs.SuspendLayout();
            report1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportTable).BeginInit();
            report2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            clientPart.SuspendLayout();
            panel1.SuspendLayout();
            clientTabs.SuspendLayout();
            orderCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProducts).BeginInit();
            deliveryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryTable).BeginInit();
            orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientOrders).BeginInit();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainTabs
            // 
            mainTabs.Controls.Add(adminPart);
            mainTabs.Controls.Add(clientPart);
            mainTabs.Dock = DockStyle.Fill;
            mainTabs.Location = new Point(0, 0);
            mainTabs.Name = "mainTabs";
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new Size(994, 590);
            mainTabs.TabIndex = 0;
            // 
            // adminPart
            // 
            adminPart.Controls.Add(adminTabs);
            adminPart.Location = new Point(4, 24);
            adminPart.Name = "adminPart";
            adminPart.Padding = new Padding(3);
            adminPart.Size = new Size(986, 562);
            adminPart.TabIndex = 0;
            adminPart.Text = "Админ";
            adminPart.UseVisualStyleBackColor = true;
            // 
            // adminTabs
            // 
            adminTabs.Controls.Add(profile);
            adminTabs.Controls.Add(allProducts);
            adminTabs.Controls.Add(allOrders);
            adminTabs.Controls.Add(allClients);
            adminTabs.Controls.Add(reports);
            adminTabs.Dock = DockStyle.Fill;
            adminTabs.Location = new Point(3, 3);
            adminTabs.Name = "adminTabs";
            adminTabs.SelectedIndex = 0;
            adminTabs.Size = new Size(980, 556);
            adminTabs.TabIndex = 0;
            adminTabs.Click += adminTabs_Click;
            // 
            // profile
            // 
            profile.Controls.Add(label3);
            profile.Controls.Add(label2);
            profile.Controls.Add(pictureBox1);
            profile.Location = new Point(4, 24);
            profile.Name = "profile";
            profile.Size = new Size(972, 528);
            profile.TabIndex = 4;
            profile.Text = "Профиль";
            profile.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(247, 88);
            label3.Name = "label3";
            label3.Size = new Size(383, 50);
            label3.TabIndex = 2;
            label3.Text = "Приложение разработано ФИО 37 группа \r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(247, 3);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 1;
            label2.Text = "Админ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.фмф1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // allProducts
            // 
            allProducts.Controls.Add(label9);
            allProducts.Controls.Add(label8);
            allProducts.Controls.Add(textBox2);
            allProducts.Controls.Add(textBox1);
            allProducts.Controls.Add(button10);
            allProducts.Controls.Add(button9);
            allProducts.Controls.Add(button7);
            allProducts.Controls.Add(allProductsTable);
            allProducts.Location = new Point(4, 24);
            allProducts.Name = "allProducts";
            allProducts.Padding = new Padding(3);
            allProducts.Size = new Size(972, 528);
            allProducts.TabIndex = 0;
            allProducts.Text = "Товары";
            allProducts.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(773, 56);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 11;
            label9.Text = "Цена";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(773, 12);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 10;
            label8.Text = "Название";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(773, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(773, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button10
            // 
            button10.Location = new Point(773, 173);
            button10.Name = "button10";
            button10.Size = new Size(193, 23);
            button10.TabIndex = 6;
            button10.Text = "Удалить";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnDeleteProduct_Click;
            // 
            // button9
            // 
            button9.Location = new Point(773, 144);
            button9.Name = "button9";
            button9.Size = new Size(193, 23);
            button9.TabIndex = 5;
            button9.Text = "Изменить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnEditProduct_Click;
            // 
            // button7
            // 
            button7.Location = new Point(773, 115);
            button7.Name = "button7";
            button7.Size = new Size(193, 23);
            button7.TabIndex = 4;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // allProductsTable
            // 
            allProductsTable.AllowUserToAddRows = false;
            allProductsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            allProductsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allProductsTable.BackgroundColor = SystemColors.Window;
            allProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductsTable.Location = new Point(3, 3);
            allProductsTable.Name = "allProductsTable";
            allProductsTable.Size = new Size(764, 433);
            allProductsTable.TabIndex = 3;
            // 
            // allOrders
            // 
            allOrders.Controls.Add(allOrdersTable);
            allOrders.Location = new Point(4, 24);
            allOrders.Name = "allOrders";
            allOrders.Padding = new Padding(3);
            allOrders.Size = new Size(972, 528);
            allOrders.TabIndex = 1;
            allOrders.Text = "Заказы";
            allOrders.UseVisualStyleBackColor = true;
            // 
            // allOrdersTable
            // 
            allOrdersTable.AllowUserToAddRows = false;
            allOrdersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            allOrdersTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allOrdersTable.BackgroundColor = SystemColors.Window;
            allOrdersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allOrdersTable.Location = new Point(3, 3);
            allOrdersTable.Name = "allOrdersTable";
            allOrdersTable.Size = new Size(764, 470);
            allOrdersTable.TabIndex = 2;
            // 
            // allClients
            // 
            allClients.Controls.Add(allClientsTable);
            allClients.Location = new Point(4, 24);
            allClients.Name = "allClients";
            allClients.Size = new Size(972, 528);
            allClients.TabIndex = 2;
            allClients.Text = "Клиенты";
            allClients.UseVisualStyleBackColor = true;
            // 
            // allClientsTable
            // 
            allClientsTable.AllowUserToAddRows = false;
            allClientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            allClientsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allClientsTable.BackgroundColor = SystemColors.Window;
            allClientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allClientsTable.Location = new Point(1, 0);
            allClientsTable.Name = "allClientsTable";
            allClientsTable.Size = new Size(764, 497);
            allClientsTable.TabIndex = 2;
            // 
            // reports
            // 
            reports.Controls.Add(reportsTabs);
            reports.Location = new Point(4, 24);
            reports.Name = "reports";
            reports.Size = new Size(972, 528);
            reports.TabIndex = 3;
            reports.Text = "Отчетность ";
            reports.UseVisualStyleBackColor = true;
            // 
            // reportsTabs
            // 
            reportsTabs.Alignment = TabAlignment.Right;
            reportsTabs.Controls.Add(report1);
            reportsTabs.Controls.Add(report2);
            reportsTabs.Dock = DockStyle.Fill;
            reportsTabs.Location = new Point(0, 0);
            reportsTabs.Multiline = true;
            reportsTabs.Name = "reportsTabs";
            reportsTabs.SelectedIndex = 0;
            reportsTabs.Size = new Size(972, 528);
            reportsTabs.TabIndex = 0;
            // 
            // report1
            // 
            report1.Controls.Add(button6);
            report1.Controls.Add(button4);
            report1.Controls.Add(label5);
            report1.Controls.Add(label4);
            report1.Controls.Add(dateTimePicker4);
            report1.Controls.Add(dateTimePicker3);
            report1.Controls.Add(reportTable);
            report1.Location = new Point(4, 4);
            report1.Name = "report1";
            report1.Padding = new Padding(3);
            report1.Size = new Size(941, 520);
            report1.TabIndex = 0;
            report1.Text = "Отчет1";
            report1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(741, 398);
            button6.Name = "button6";
            button6.Size = new Size(194, 23);
            button6.TabIndex = 9;
            button6.Text = "Сохранить отчет";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(741, 355);
            button4.Name = "button4";
            button4.Size = new Size(194, 23);
            button4.TabIndex = 8;
            button4.Text = "Сформировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(741, 86);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 7;
            label5.Text = "по";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(740, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 45);
            label4.TabIndex = 6;
            label4.Text = "Сформировать отчет \r\n\r\nС\r\n";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(740, 104);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(194, 23);
            dateTimePicker4.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(741, 48);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(194, 23);
            dateTimePicker3.TabIndex = 4;
            // 
            // reportTable
            // 
            reportTable.AllowUserToAddRows = false;
            reportTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reportTable.BackgroundColor = SystemColors.Window;
            reportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportTable.Location = new Point(6, 6);
            reportTable.Name = "reportTable";
            reportTable.Size = new Size(728, 497);
            reportTable.TabIndex = 3;
            // 
            // report2
            // 
            report2.Controls.Add(checkBox5);
            report2.Controls.Add(checkBox4);
            report2.Controls.Add(checkBox3);
            report2.Controls.Add(checkBox2);
            report2.Controls.Add(checkBox1);
            report2.Controls.Add(chart1);
            report2.Controls.Add(button8);
            report2.Controls.Add(label6);
            report2.Controls.Add(label7);
            report2.Controls.Add(dateTimePicker5);
            report2.Controls.Add(dateTimePicker6);
            report2.Location = new Point(4, 4);
            report2.Name = "report2";
            report2.Padding = new Padding(3);
            report2.Size = new Size(941, 520);
            report2.TabIndex = 1;
            report2.Text = "Отчет2";
            report2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(6, 6);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(729, 425);
            chart1.TabIndex = 16;
            chart1.Text = "chart1";
            chart1.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(741, 349);
            button8.Name = "button8";
            button8.Size = new Size(194, 23);
            button8.TabIndex = 14;
            button8.Text = "Сформировать";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(741, 90);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 13;
            label6.Text = "по";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(741, 3);
            label7.Name = "label7";
            label7.Size = new Size(127, 45);
            label7.TabIndex = 12;
            label7.Text = "Сформировать отчет \r\n\r\nС\r\n";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(741, 107);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(194, 23);
            dateTimePicker5.TabIndex = 11;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(742, 51);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(194, 23);
            dateTimePicker6.TabIndex = 10;
            // 
            // clientPart
            // 
            clientPart.Controls.Add(panel1);
            clientPart.Controls.Add(clientTabs);
            clientPart.Location = new Point(4, 24);
            clientPart.Name = "clientPart";
            clientPart.Padding = new Padding(3);
            clientPart.Size = new Size(986, 562);
            clientPart.TabIndex = 1;
            clientPart.Text = "Клиент";
            clientPart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(exit);
            panel1.Controls.Add(choice);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clients);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 556);
            panel1.TabIndex = 2;
            // 
            // exit
            // 
            exit.Location = new Point(3, 73);
            exit.Name = "exit";
            exit.Size = new Size(86, 23);
            exit.TabIndex = 11;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = true;
            exit.Visible = false;
            exit.Click += exit_Click;
            // 
            // choice
            // 
            choice.Location = new Point(110, 73);
            choice.Name = "choice";
            choice.Size = new Size(86, 23);
            choice.TabIndex = 10;
            choice.Text = "Выбрать";
            choice.UseVisualStyleBackColor = true;
            choice.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 9;
            label1.Text = "Для начала работы выберите \r\nклиента\r\n";
            // 
            // clients
            // 
            clients.FormattingEnabled = true;
            clients.Items.AddRange(new object[] { "Ирина Смирнова", "Андрей Козлов", "Мария Васнецова", "Павел Новиков", "Екатерина Морозова" });
            clients.Location = new Point(3, 44);
            clients.Name = "clients";
            clients.Size = new Size(193, 23);
            clients.TabIndex = 0;
            // 
            // clientTabs
            // 
            clientTabs.Controls.Add(orderCreate);
            clientTabs.Controls.Add(deliveryList);
            clientTabs.Controls.Add(orders);
            clientTabs.Controls.Add(info);
            clientTabs.Location = new Point(207, 8);
            clientTabs.Name = "clientTabs";
            clientTabs.SelectedIndex = 0;
            clientTabs.Size = new Size(779, 554);
            clientTabs.TabIndex = 1;
            clientTabs.Visible = false;
            clientTabs.Click += clientTabs_Click;
            // 
            // orderCreate
            // 
            orderCreate.Controls.Add(totalSum);
            orderCreate.Controls.Add(radioButton2);
            orderCreate.Controls.Add(radioButton1);
            orderCreate.Controls.Add(button3);
            orderCreate.Controls.Add(numProducts);
            orderCreate.Controls.Add(button2);
            orderCreate.Controls.Add(button1);
            orderCreate.Controls.Add(selectedProducts);
            orderCreate.Controls.Add(products);
            orderCreate.Controls.Add(dateTimePicker1);
            orderCreate.Location = new Point(4, 24);
            orderCreate.Name = "orderCreate";
            orderCreate.Padding = new Padding(3);
            orderCreate.Size = new Size(771, 526);
            orderCreate.TabIndex = 0;
            orderCreate.Text = "Сделать заказ";
            orderCreate.UseVisualStyleBackColor = true;
            // 
            // totalSum
            // 
            totalSum.AutoSize = true;
            totalSum.Location = new Point(164, 363);
            totalSum.Name = "totalSum";
            totalSum.Size = new Size(48, 15);
            totalSum.TabIndex = 9;
            totalSum.Text = "Сумма:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(264, 394);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Картой";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(164, 394);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Наличными";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(161, 433);
            button3.Name = "button3";
            button3.Size = new Size(461, 23);
            button3.TabIndex = 6;
            button3.Text = "Заказать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // numProducts
            // 
            numProducts.Location = new Point(164, 259);
            numProducts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numProducts.Name = "numProducts";
            numProducts.Size = new Size(458, 23);
            numProducts.TabIndex = 5;
            numProducts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(547, 297);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(164, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // selectedProducts
            // 
            selectedProducts.FormattingEnabled = true;
            selectedProducts.ItemHeight = 15;
            selectedProducts.Location = new Point(164, 159);
            selectedProducts.Name = "selectedProducts";
            selectedProducts.Size = new Size(458, 94);
            selectedProducts.TabIndex = 2;
            // 
            // products
            // 
            products.FormattingEnabled = true;
            products.Items.AddRange(new object[] { "Робот-пылесос Xiaomi Mi Robot Vacuum  ", "Электрический чайник Bosch TWK7201  ", "Набор кастрюль Tefal Ingenio 5 предметов ", "Утюг с парогенератом Philips PerfectCare ", "Кофемашина DeLonghi Magnifica S ", "Плед из верблюжьей шерсти 140x200 см ", "Настольная лампа с USB-портом ", "Микроволновая печь Samsung ME83KRW-1 ", "Набор кухонных ножей Samura 6 предметов ", "Электронные весы REDMOND SkyBalance 741S " });
            products.Location = new Point(164, 106);
            products.Name = "products";
            products.Size = new Size(458, 23);
            products.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(458, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // deliveryList
            // 
            deliveryList.Controls.Add(button5);
            deliveryList.Controls.Add(dateTimePicker2);
            deliveryList.Controls.Add(deliveryTable);
            deliveryList.Location = new Point(4, 24);
            deliveryList.Name = "deliveryList";
            deliveryList.Size = new Size(771, 526);
            deliveryList.TabIndex = 2;
            deliveryList.Text = "Доставка";
            deliveryList.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(608, 59);
            button5.Name = "button5";
            button5.Size = new Size(159, 23);
            button5.TabIndex = 2;
            button5.Text = "Доставлен";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(608, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(159, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // deliveryTable
            // 
            deliveryTable.AllowUserToAddRows = false;
            deliveryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            deliveryTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            deliveryTable.BackgroundColor = SystemColors.Window;
            deliveryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryTable.Location = new Point(7, 3);
            deliveryTable.Name = "deliveryTable";
            deliveryTable.Size = new Size(595, 470);
            deliveryTable.TabIndex = 0;
            // 
            // orders
            // 
            orders.Controls.Add(clientOrders);
            orders.Location = new Point(4, 24);
            orders.Name = "orders";
            orders.Size = new Size(771, 526);
            orders.TabIndex = 3;
            orders.Text = "Заказы";
            orders.UseVisualStyleBackColor = true;
            // 
            // clientOrders
            // 
            clientOrders.AllowUserToAddRows = false;
            clientOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            clientOrders.BackgroundColor = SystemColors.Window;
            clientOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientOrders.Location = new Point(3, 3);
            clientOrders.Name = "clientOrders";
            clientOrders.Size = new Size(764, 470);
            clientOrders.TabIndex = 1;
            clientOrders.Visible = false;
            // 
            // info
            // 
            info.Controls.Add(pictureBox2);
            info.Controls.Add(info_client);
            info.Controls.Add(name_client);
            info.Controls.Add(id_client);
            info.Location = new Point(4, 24);
            info.Name = "info";
            info.Size = new Size(771, 526);
            info.TabIndex = 4;
            info.Text = "Инфо";
            info.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.фмф1;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // info_client
            // 
            info_client.AutoSize = true;
            info_client.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            info_client.Location = new Point(198, 100);
            info_client.Name = "info_client";
            info_client.Size = new Size(102, 25);
            info_client.TabIndex = 2;
            info_client.Text = "Контакты: ";
            // 
            // name_client
            // 
            name_client.AutoSize = true;
            name_client.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_client.Location = new Point(198, 62);
            name_client.Name = "name_client";
            name_client.Size = new Size(58, 25);
            name_client.TabIndex = 1;
            name_client.Text = "Имя: ";
            // 
            // id_client
            // 
            id_client.AutoSize = true;
            id_client.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            id_client.Location = new Point(198, 19);
            id_client.Name = "id_client";
            id_client.Size = new Size(94, 25);
            id_client.TabIndex = 0;
            id_client.Text = "Клиент№";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(743, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Tag = "1";
            checkBox1.Text = "Ирина Смирнова";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(743, 186);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(109, 19);
            checkBox2.TabIndex = 18;
            checkBox2.Tag = "2";
            checkBox2.Text = "Андрей Козлов";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(743, 211);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(124, 19);
            checkBox3.TabIndex = 19;
            checkBox3.Tag = "3";
            checkBox3.Text = "Мария Васнецова";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(743, 236);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(111, 19);
            checkBox4.TabIndex = 20;
            checkBox4.Tag = "4";
            checkBox4.Text = "Павел Новиков";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(743, 261);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(141, 19);
            checkBox5.TabIndex = 21;
            checkBox5.Tag = "5";
            checkBox5.Text = "Екатерина Морозова";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 590);
            Controls.Add(mainTabs);
            Name = "Form1";
            Text = "Form1";
            mainTabs.ResumeLayout(false);
            adminPart.ResumeLayout(false);
            adminTabs.ResumeLayout(false);
            profile.ResumeLayout(false);
            profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            allProducts.ResumeLayout(false);
            allProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allProductsTable).EndInit();
            allOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allOrdersTable).EndInit();
            allClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)allClientsTable).EndInit();
            reports.ResumeLayout(false);
            reportsTabs.ResumeLayout(false);
            report1.ResumeLayout(false);
            report1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportTable).EndInit();
            report2.ResumeLayout(false);
            report2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            clientPart.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            clientTabs.ResumeLayout(false);
            orderCreate.ResumeLayout(false);
            orderCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProducts).EndInit();
            deliveryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deliveryTable).EndInit();
            orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientOrders).EndInit();
            info.ResumeLayout(false);
            info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabs;
        private TabPage adminPart;
        private TabPage clientPart;
        private TabControl clientTabs;
        private TabPage orderCreate;
        private DateTimePicker dateTimePicker1;
        private ListBox selectedProducts;
        private ComboBox products;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private NumericUpDown numProducts;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Button choice;
        private ComboBox clients;
        private Label totalSum;
        private TabPage deliveryList;
        private Button button5;
        private DateTimePicker dateTimePicker2;
        private DataGridView deliveryTable;
        private Button exit;
        private TabPage orders;
        private TabPage info;
        private Label id_client;
        private Label info_client;
        private Label name_client;
        private DataGridView clientOrders;
        private TabControl adminTabs;
        private TabPage allProducts;
        private TabPage allOrders;
        private TabPage allClients;
        private TabPage reports;
        private TabControl reportsTabs;
        private TabPage report1;
        private TabPage report2;
        private DataGridView allOrdersTable;
        private DataGridView allClientsTable;
        private TabPage profile;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView allProductsTable;
        private DateTimePicker dateTimePicker3;
        private DataGridView reportTable;
        private Button button4;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker4;
        private Button button6;
        private Button button8;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button10;
        private Button button9;
        private Button button7;
        private Label label9;
        private Label label8;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
