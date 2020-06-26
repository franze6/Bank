using Bank.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DBWorker
    {
        SqlConnection dbConnection = null;
        public bool Connect()
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=bank;Integrated Security=True";
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Employ> GetEmployList()
        {
            var resultList = new List<Employ>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT Код_сотрудника, ФИО_сотрудника FROM Сотрудники";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            resultList.Add(new Employ(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<ClientType> GetClientTypes()
        {
            var resultList = new List<ClientType>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Типы_клиентов";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new ClientType(reader.GetInt32(0), reader.GetDouble(1), reader.GetString(2)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<AppealType> GetAppealTypes()
        {
            var resultList = new List<AppealType>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Типы_обращения";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new AppealType(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<DealType> GetDealTypes()
        {
            var resultList = new List<DealType>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Типы_сделок";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new DealType(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<ClientSpec> GetClientSpecs()
        {
            var resultList = new List<ClientSpec>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Виды_клиентов";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new ClientSpec(reader.GetInt32(0), reader.GetDouble(1), reader.GetString(2)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<ViewDeal> GetViewDealsByClientId(int id)
        {
            List<ViewDeal> resultList = new List<ViewDeal>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT Сделки.Код_сделки, 
                                            ФИО_коллектора, 
                                            ФИО_клиента, 
                                            ФИО_сотрудника, 
                                            Код_счета_в_банке, 
                                            Код_обращения, 
                                            название_типа_сделки, 
                                            дата_сделки, 
                                            сумма_сделки, 
                                            флаг_завершения 
                                            FROM Сделки
                                            LEFT JOIN Коллекторы ON Коллекторы.Код_коллектора = Сделки.Код_коллектора
                                            LEFT JOIN Клиенты ON Клиенты.Код_клиента = Сделки.Код_клиента
                                            LEFT JOIN Сотрудники ON Сотрудники.Код_сотрудника = Сделки.Код_сотрудника
                                            LEFT JOIN Типы_сделок ON Типы_сделок.Код_типа_сделки = Сделки.Код_типа_сделки
                                            WHERE Сделки.Код_клиента = {id}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new ViewDeal(reader.GetInt32(0), reader.IsDBNull(1) ? "пусто" : reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4),
                                !reader.IsDBNull(5), reader.GetString(6), reader.GetDateTime(7).ToString(), (int)reader.GetSqlMoney(8).ToSqlInt32(), reader.GetInt32(9) != 0));
                        }
                    }
                }
            }
            return resultList;
        }

        public ViewDeal GetViewDealById(int id)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT Сделки.Код_сделки, 
                                            ФИО_коллектора, 
                                            ФИО_клиента, 
                                            ФИО_сотрудника, 
                                            Код_счета_в_банке, 
                                            Код_обращения, 
                                            название_типа_сделки, 
                                            дата_сделки, 
                                            сумма_сделки, 
                                            флаг_завершения 
                                            FROM Сделки
                                            LEFT JOIN Коллекторы ON Коллекторы.Код_коллектора = Сделки.Код_коллектора
                                            LEFT JOIN Клиенты ON Клиенты.Код_клиента = Сделки.Код_клиента
                                            LEFT JOIN Сотрудники ON Сотрудники.Код_сотрудника = Сделки.Код_сотрудника
                                            LEFT JOIN Типы_сделок ON Типы_сделок.Код_типа_сделки = Сделки.Код_типа_сделки
                                            WHERE Сделки.Код_сделки = {id}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return new ViewDeal(reader.GetInt32(0), reader.IsDBNull(1) ? "пусто" : reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4),
                                !reader.IsDBNull(5), reader.GetString(6), reader.GetDateTime(7).ToString(), (int)reader.GetSqlMoney(8).ToSqlInt32(), reader.GetInt32(9) != 0);
                        }
                    }
                }
            }
            return null;
        }
        public Deal GetDealById(int id)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT * FROM Сделки WHERE Код_сделки = {id}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return new Deal(reader.GetInt32(0), reader.IsDBNull(1) ? 0 : reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), 
                                !reader.IsDBNull(5), reader.GetInt32(6), reader.GetDateTime(7).ToString(), (int)reader.GetSqlMoney(8).ToSqlInt32(), reader.GetInt32(9) != 0);
                        }
                    }
                }
            }
            return null;
        }

        public List<ViewAppeal> GetAppealsByClientId(int id)
        {
            List<ViewAppeal> resultList = new List<ViewAppeal>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT Обращения.Код_обращения, 
                                                ФИО_клиента, 
                                                ФИО_сотрудника, 
                                                название_типа_обращения, 
                                                дата_обращения, 
                                                оценка_обслуживания FROM Обращения
                                                LEFT JOIN Клиенты ON Клиенты.Код_клиента = Обращения.Код_клиента
                                                LEFT JOIN Сотрудники ON Сотрудники.Код_сотрудника = Обращения.Код_сотрудника
                                                LEFT JOIN Типы_обращения ON Типы_обращения.Код_типа_обращения = Обращения.Код_типа_обращения 
                                                WHERE Обращения.Код_клиента = {id}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new ViewAppeal(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                reader.GetDateTime(4).ToString(), reader.IsDBNull(5) ? 0 : reader.GetInt32(5)));
                        }
                    }
                }
            }
            return resultList;
        }

        public Client SearchClient(Client data)
        {
            var result = new Client();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                
                command.CommandText = @"SELECT Код_клиента, Код_типа_клиента, Код_вида_клиента, ФИО_клиента, паспорт, адрес, телефон, email  FROM Клиенты WHERE ";
                if (data.Name.Length > 3)
                    command.CommandText += $@"ФИО_клиента LIKE '%{data.Name}%' AND ";
                if (data.Cred.Length > 3)
                    command.CommandText += $@"паспорт LIKE '%{data.Cred}%' AND ";
                if (data.Phone.Length > 3)
                    command.CommandText += $@"телефон LIKE '%{data.Phone}%' AND ";
                command.CommandText += "1=1";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Id = reader.GetInt32(0);
                            result.TypeId = reader.GetInt32(1);
                            result.SpecId = reader.GetInt32(2);
                            result.Name = reader.GetString(3);
                            result.Cred = reader.GetString(4);
                            result.Adress = reader.GetString(5);
                            result.Phone = reader.GetString(6);
                            result.Email = reader.GetString(7);
                        }
                    }
                    else
                        throw new Exception("Клиент не найден!");
                }
            }
            return result;
        }

        public List<Collector> GetCollectors()
        {
            var resultList = new List<Collector>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Коллекторы";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new Collector(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                        }
                    }
                }
            }
            return resultList;
        }

        public List<Scope> GetScopesByClientId(int clientId)
        {
            var resultList = new List<Scope>();
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT * FROM Счета WHERE Код_клиента = {clientId}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            resultList.Add(new Scope(reader.GetInt32(0), reader.GetInt32(1), reader.GetSqlMoney(2).ToInt32()));
                        }
                    }
                }
            }
            return resultList;
        }
        
        public double GetDealPersent(int clientId, int dealTypeId)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"SELECT ROUND(Кредитные_истории.коэф_Корр_процента*Типы_клиентов.коэф_Корр_процента*Виды_клиентов.коэф_Корр_процента*Типы_сделок.процент_сделки, 2) as 'Процент сделки' FROM Клиенты 
                                        INNER JOIN Кредитные_истории ON Кредитные_истории.Код_клиента = Клиенты.Код_клиента
                                        INNER JOIN Типы_клиентов ON Типы_клиентов.Код_типа_клиента = Клиенты.Код_типа_клиента
                                        INNER JOIN Виды_клиентов ON Виды_клиентов.Код_вида_клиента = Клиенты.Код_вида_клиента
                                        INNER JOIN Типы_сделок ON Типы_сделок.Код_типа_сделки = {dealTypeId}
                                        WHERE Клиенты.Код_клиента = {clientId}";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return reader.GetDouble(0);
                        }
                    }
                }
            }
            return 0;
        }

        public void addClient(Client client)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"EXEC add_client  @name = N'{client.Name}',  @adr = N'{client.Adress}',  @tel = N'{client.Phone}',  @cred = N'{client.Cred}',  @em = N'{client.Email}',  @c_type = '{client.TypeId}',  @c_spec = '{client.SpecId}' ";
                command.ExecuteNonQuery();
            }
        }

        public void updateClient(Client client)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"EXEC up_client  @id = N'{client.Id}',  @adr = N'{client.Adress}',  @tel = N'{client.Phone}',  @cred = N'{client.Cred}',  @em = N'{client.Email}',  @c_type = '{client.TypeId}',  @c_spec = '{client.SpecId}' ";
                command.ExecuteNonQuery();
            }
        }

        public void attachCollector(int dealId, int collectorId)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"EXEC add_collector @deal_id = {dealId}, @collector_id = {collectorId}";
                command.ExecuteNonQuery();
            }
        }

        public void newDeal(Deal deal)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"EXEC add_deal @c_id = {deal.clientId}, @e_id = {deal.employId}, @a_id = {deal.appealId}, @deal_type = {deal.typeId}, @sum = {deal.sum}, @scope_id = {(deal.scopeId == 0? SqlInt32.Null : deal.scopeId)}";
                command.ExecuteNonQuery();
            }
        }

        public void newAppeal(int clientId, int employId, int appealTypeId)
        {
            if (dbConnection == null) throw new Exception("Подключение не было утсановлено!");
            using (var command = dbConnection.CreateCommand())
            {
                command.CommandText = $@"EXEC new_appeal @c_id = {clientId}, @e_id = {employId}, @a_type = {appealTypeId}";
                command.ExecuteNonQuery();
            }
        }
    }
}
