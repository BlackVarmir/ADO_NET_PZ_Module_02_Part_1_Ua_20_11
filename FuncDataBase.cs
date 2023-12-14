namespace ADO_NET_ПЗ_Модуль_02_Частина_1_Ua
{
    using System;
    using System.Data;
    using Microsoft.Data.Sqlite;
    using System.Windows.Forms;

    internal class FuncDataBase
    {
        private readonly string connectionString = "Data Source=WareHouse.sqlite;";

        private bool access = false;

        public void CreatDataBase()
        {
            string creatTableType = @"CREATE TABLE IF NOT EXISTS Type (
                                        TypeId INTEGER UNIQUE PRIMARY KEY AUTOINCREMENT,
                                        TypeTitle NVARCHAR(255) NOT NULL
                                    );";

            string creatTableManufacturer = @"CREATE TABLE IF NOT EXISTS Manufacturer (
                                                ManId INTEGER UNIQUE PRIMARY KEY AUTOINCREMENT,
                                                ManTitle NVARCHAR(255) NOT NULL
                                            );";

            string creatTableWareHouse = @"CREATE TABLE IF NOT EXISTS WareHouse (
                                            Id INTEGER UNIQUE PRIMARY KEY AUTOINCREMENT,
                                            Title NVARCHAR(255) UNIQUE NOT NULL,
                                            TypeId INTEGER NOT NULL,
                                            ManId INTEGER NOT NULL,
                                            Quantity INTEGER NOT NULL,
                                            CostPrice DECIMAL(18,2) NOT NULL,
                                            SupplyDate DATETIME NOT NULL,
                                            FOREIGN KEY(TypeId) REFERENCES Type(TypeId),
                                            FOREIGN KEY(ManId) REFERENCES Manufacturer(ManId)
                                        );";

            using (SqliteConnection connection = new SqliteConnection(this.connectionString))
            {
                connection.Open();

                using (SqliteCommand command = new SqliteCommand(creatTableType, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqliteCommand command = new SqliteCommand(creatTableManufacturer, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqliteCommand command = new SqliteCommand(creatTableWareHouse, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            string insertTableType =
                @"INSERT OR IGNORE INTO Type (TypeId, TypeTitle) VALUES (1, 'Блок живлення'), (2, 'Процесор'), (3, 'Материнська плата'), (4, 'Відеокарта'), (5, 'Оперативна память'), (6, 'Накопичувач'), (7, 'Охолодження'), (8, 'Термопаста'), (9, 'Корпус')";

            string insertTableManufacturer =
                @"INSERT OR IGNORE INTO Manufacturer (ManId, ManTitle) VALUES (1, 'Cooler Master'), (2, 'ASUS'), (3, 'Intel'), (4, 'AMD'), (5, 'MSI'), (6, 'Gigabyte'), (7, 'Kingston Fury'), (8, 'Samsung'), (9, 'Grizzly'), (10, 'Corsair')";

            string insertTableWareHouse =
                @"INSERT OR IGNORE INTO WareHouse (Title, TypeId, ManId, Quantity, CostPrice, SupplyDate) VALUES 
                                            ('Процесор Intel Core i5 Alder Lake i5-12600', 2, 3, 1, 11099, '2023-09-23'),
                                            ('Материнська плата Asus ROG STRIX B760-F GAMING WIFI', 3, 2, 2, 10549, '2023-09-24'),
                                            ('Процесор Intel Core i5 Raptor Lake i5-13500', 2, 3, 1, 11119, '2023-09-24'),
                                            ('Материнська плата Asus TUF GAMING B550M-PLUS', 3, 2, 1, 5067, '2023-09-25'),
                                            ('Процесор AMD Ryzen 7 Vermeer 5700X', 2, 4, 2, 8199, '2023-09-25'),
                                            ('Материнська плата Asus ROG STRIX B550-F GAMING WIFI II', 3, 2, 2, 7799, '2023-09-25'),
                                            ('Відеокарта Asus GeForce RTX 3070 Ti ROG Strix OC', 4, 2, 1, 37500, '2023-11-23'),
                                            ('Відеокарта MSI GeForce RTX 3070 Ti SUPRIM X 8G', 4, 5, 1, 40500, '2023-11-23'),
                                            ('Відеокарта Gigabyte GeForce RTX 3070 Ti AORUS MASTER 8G', 4, 6, 1, 36000, '2023-11-25'),
                                            ('Відеокарта Gigabyte GeForce RTX 3070 Ti GAMING 8G', 4, 6, 1, 27999, '2023-12-02'),
                                            ('Оперативна память Kingston Fury Beast DDR5 RGB 2x8Gb', 5, 7, 2, 3436, '2023-11-28'),
                                            ('Оперативна память Kingston Fury Beast RGB DDR4 2x8Gb', 5, 7, 2, 2324, '2023-11-28'),
                                            ('SSD Samsung 970 EVO Plus M.2 500GB MZ-V7S500BW', 6, 8, 4, 2702, '2023-11-28'),
                                            ('Кулер Cooler Master Hyper 212 RGB Black Edition R2', 7, 1, 4, 2702, '2023-11-28'),
                                            ('Термопаста Thermal Grizzly Aeronaut 1g', 8, 9, 4, 190, '2023-09-23'),
                                            ('Жорсткий диск Seagate IronWolf 2TB ST2000VN003', 6, 10, 4, 3494, '2023-09-24'),
                                            ('Блок живлення Asus Prime Gold AP-850G', 1, 2, 2, 5520, '2023-09-25'),
                                            ('Блок живлення Cooler Master Elite NEX White 230V MPW-7001-ACBW-B', 1, 1, 2, 3572, '2023-09-25'),
                                            ('Корпус Corsair Obsidian 500D RGB', 9, 10, 2, 14570, '2023-09-25'),
                                            ('Корпус Corsair iCUE 5000X RGB QL White', 9, 10, 2, 12499, '2023-09-25')";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (SqliteCommand command = new SqliteCommand(insertTableType, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqliteCommand command = new SqliteCommand(insertTableManufacturer, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqliteCommand command = new SqliteCommand(insertTableWareHouse, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Connect()
        {
            using SqliteConnection connection = new SqliteConnection(connectionString);

            if (access)
            {
                MessageBox.Show("Ви вже є підключені до бази даних.", "Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            else
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Успішне підключення!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    access = true;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Підключення невдалося. Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    access = false;
                    return false;
                }
            }
        }

        public void Disconnect(DataGridView field)
        {
            field.DataSource = null;
            MessageBox.Show("Від'єдналися!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            access = false;
        }

        public async Task PrintDataBase(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId";
                    SqliteCommand command = new SqliteCommand(query, connection);

                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintAllType(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT TypeId AS 'Id', TypeTitle AS 'Назва' FROM Type";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintAllMan(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT ManId AS 'Id', ManTitle AS 'Назва' FROM Manufacturer";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintMaxQuantity(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                     WHERE Quantity = (SELECT MAX(Quantity) FROM WareHouse)";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintMinQuantity(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                     WHERE Quantity = (SELECT MIN(Quantity) FROM WareHouse)";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintMaxCostPrice(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                     WHERE CostPrice = (SELECT MAX(CostPrice) FROM WareHouse)";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintMinCostPrice(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                     WHERE CostPrice = (SELECT MIN(CostPrice) FROM WareHouse)";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintWareHouseByCategory(DataGridView field, string category, RadioButton radioButton)
        {
            if (access && radioButton.Checked)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        $@"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                      Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                      JOIN Type ON WareHouse.TypeId = Type.TypeId
                                      JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                      WHERE Type.TypeTitle = '{category}'";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintWareHouseByMan(DataGridView field, string man, RadioButton radioButton)
        {
            if (access && radioButton.Checked)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query =
                        $@"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                      Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                      JOIN Type ON WareHouse.TypeId = Type.TypeId
                                      JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                      WHERE Manufacturer.ManTitle = '{man}'";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintWareHouseOld(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT Id AS 'Id', Title AS 'Назва', Type.TypeTitle AS 'Тип', Manufacturer.ManTitle AS 'Постачальник',
                                     Quantity AS 'Кількість', CostPrice AS 'Собівартість', SupplyDate AS 'Дата постачання' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId
                                     JOIN Manufacturer ON WareHouse.ManId = Manufacturer.ManId
                                     ORDER BY SupplyDate LIMIT 1";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

        public async Task PrintAvarageByType(DataGridView field)
        {
            if (access)
            {
                field.DataSource = string.Empty;

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT Type.TypeTitle AS 'Тип', ROUND(AVG(Quantity), 2) AS 'Середня кількість' FROM WareHouse
                                     JOIN Type ON WareHouse.TypeId = Type.TypeId 
                                     GROUP BY TypeTitle";
                    SqliteCommand command = new SqliteCommand(query, connection);

                    using SqliteDataReader reader = await command.ExecuteReaderAsync();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    field.DataSource = dataTable;
                }
            }
        }

    }
}
