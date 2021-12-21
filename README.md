# Онлайн-регистратура частной клиники
## `Содержание`
[Введение](#введение)

1 [Описание предметной области](#по)

1.1 [Указание на проблематику](#проблематика) 

1.2 [Формулировка задачи](#формулировка_задачи)

2  [Существующие решения проблемы](#решения_проблемы)

3 [Разработка](#разработка_системы)

3.1 [Проектирование системы](#проектирование)

3.2 [Реализация системы](#реализация)

4 [Тестирование](#тестирование)

[Заключение](#заключение)

[Список литературы](#список_литературы)

***
## Введение <a name ="введение"></a>
Темой проекта является "Онлайн-регистратура частной клиники", позволяет дистанционно записаться на прием или проконсультироваться с врачем онлайн. Сегодня это особенно важно, ведь клиенту не придется лишний раз посещать клинику и контактировать с другими больными. Это все позволяет обеспечить удобство проведения лечения для пациента. На сегодняшний день данная информационная система является как никогда актульной в связи с эпидемией коронавируса.
***
## 1 Описание предметной области <a name ="по"></a>
Человек нуждающийся в специализированной медицинской помощи может с легкостью обратиться за ней. Клиент заходит на сайт и может записаться ко врачу на прием непосредствено ко врачу в клинику, либо пройти онлайн-констультацию со специалистом на сайте. Записавшись на прием, клиент предоставляет свои документы и производит оплату, а регистратура обрабатывает полученные данные и направляет пациента ко врачу, который проводит прием и лечение.
***
  ### 1.1 Указание на проблематику <a name ="проблематика"></a>
  Постоянные очереди ко врачу подвергают пациентов опасности, ведь контактируя с другими больными человек может заразиться другими болезнями. Также часто больным сложно по долгу находится в специализированных лечебных заведениях, просто ожидая своей очереди. Представленная информационная система позволяет удобно записать клиентов клиники, чтобы они не теряли свое время в очередях и лишних походах в лечебное учреждение.
***
  ### 1.2 Формулировка задачи <a name ="формулировка_задачи"></a>
  Целью проекта является создание сайта частной клиники, предоставляющий пользователям удобную запись на прием.
  
  Задачи:
  1. Предоставление простой и понятной пользователю возможности записи на прием.
  2. Возможность пройти дистанционную консультацию со специалистом.
***
## 2 Существующие решения проблемы <a name ="решения_проблемы"></a>
***
## 3 Разработка системы <a name ="разработка_системы"></a>
***
### 3.1 Проектирование системы <a name="проектирование"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.(см. рисунок 1)

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.[5]
<p align="center">
<img src = "https://user-images.githubusercontent.com/90554731/146810331-5e36b579-0ef2-4207-8cc1-2db020229daa.png"></p>
  <p align="center">Рисунок 1 - Диаграмма вариантов использования</p> 
  На основе USE-CASE диаграммы разрабатвается DFD диаграмма, которая наглядно отображает течение информации в пределах системы.(см. рисунок 2 и рисунок 3)
<p align="center">
<img src = "https://user-images.githubusercontent.com/90554731/146811582-736a5426-a1c5-49b6-82a4-e1cedca7c76e.PNG"></p>
  <p align="center">Рисунок 2 - Диаграмма потоков данных</p>  
  <p align="center">
<img src = "https://user-images.githubusercontent.com/90554731/146811600-c8e94d6b-cda4-4851-ab82-80ab05280737.PNG"></p>
  <p align="center">Рисунок 3 - Диаграмма потоков данных</p>  
  На основе DFD диаграммы проектируется схема «сущность-связь» (ER-диаграмма), где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.(см. рисунок 4)
<p align="center">
<img src = "https://user-images.githubusercontent.com/90554731/146953128-9ac0628e-b749-411c-a9b0-cf7731fc4f9b.png"></p>
<p align="center">Рисунок 4 - Диаграмма «сущность-связь»</p> 

***
### 3.2 Реализация системы <a name="реализация"></a>
На основании ER-диаграммы создали классы. Примеры классов "Клиент" и "Документы" представленны на листингах 1 и 2 соответственно.

Листинг 1 - Класс "Клиент"
```csharp
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MedicalBook { get; set; }
        public string Pasport { get; set; }
        public string Phone { get; set; }
        public string Snils { get; set; }
    }
```
Листинг 2 - Класс "Документы"
```csharp
    public class DataBaseDocuments
    {
        public int Id { get; set; }
        public int Client { get; set; }
        public int Doctor { get; set; }
        public int Registry { get; set; }
    }
```

Затем отпределили где они будут храниться, создав репозитории, пример на листинге 3. Также на листинге 4 представлено общее хранилище.

Листинг 3 - Репрезиторий для класса "Клиент"
```csharp
    public class ClientStorage
    {
        private readonly Dictionary<int, Client> _clients  = new ();

        public void Create(Client client)
        {
            _clients.Add(client.Id, client);
        }

        public Client Read(int clientId)
        {
            return _clients[clientId];
        }

        public Client Update(int clientId, Client newClient)
        {
            _clients[clientId] = newClient;
            return _clients[clientId];
        }

        public bool Delete(int clientId)
        {
            return _clients.Remove(clientId);
        }
    }
```
Листинг 4 - Общеее хранилище
```csharp
    public class Storage
    {
        public static readonly ClientStorage ClientStorage = new();
        public static readonly DoctorStorage DoctorStorage = new();
        public static readonly RegistryStorage RegistryStorage = new();
        public static readonly TypesRecordsStorage TypesRecordsStorage = new();
        public static readonly DataBaseRecordsStorage DataBaseRecordsStorage = new();
        public static readonly DataBasePaymentsStorage DataBasePaymentsStorage = new();
        public static readonly DataBaseDocumentsStorage DataBaseDocumentsStorage = new();
        public static readonly DataBaseDoctorsScheduleStorage DataBaseDoctorsScheduleStorage = new();
    }
```
Разработали набор web-методов, включая 4 базисные операции CRUD, для каждой сущности, отражающих предметную область. Примеры контроллеров для классов "Клиент" и "Документы" представлены на листингах 5 и 6.

Листинг 5 - Контроллер для класса "Клиент"
```csharp
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("Recording")]
        public string Recording(string str)
        {
            return str; 
        }

        [HttpGet("Payment")]
        public string Payment(string str)
        {
            return str;
        }


        [HttpGet("DocumentsCL")]
        public string DocumentsCL(string str)
        {
            return str;
        }

        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return Storage.ClientStorage.Read(client.Id);
        }

        [HttpGet]
        public Client Read(int Id)
        {
            return Storage.ClientStorage.Read(Id);
        }

        [HttpPatch]
        public Client Update(int Id, Client newClient)
        {
            return Storage.ClientStorage.Update(Id, newClient);
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            return Storage.ClientStorage.Delete(Id);
        }
    }
```
Листинг 6 - Контроллер для класса "Документы"
```csharp
    [ApiController]
    [Route("/dataBaseDocuments")]
    public class DataBaseDocumentsController : ControllerBase
    {

        [HttpPut("Create")]
        public DataBaseDocuments Create(DataBaseDocuments dataDoc)
        {
            Storage.DataBaseDocumentsStorage.Create(dataDoc);
            return Storage.DataBaseDocumentsStorage.Read(dataDoc.Id);
        }

        [HttpGet("Read")]
        public DataBaseDocuments Read(int Id)
        {
            return Storage.DataBaseDocumentsStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public DataBaseDocuments Update(int Id, DataBaseDocuments newDataDoc)
        {
            return Storage.DataBaseDocumentsStorage.Update(Id, newDataDoc);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.DataBaseDocumentsStorage.Delete(Id);
        }
    }
```

***
## 4 Тестирование <a name ="тестирование"></a>

***
## Заключение <a name="заключение"></a>

***
## Cписок литературы <a name="список_литературы"></a>  
