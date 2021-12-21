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

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.
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
После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними (см. рисунок 5).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956844-0b57b8d2-337e-4626-b22c-30e553d4f05f.PNG"</p>
<p align="center">Рисунок 5 - Cтраница Swagger UI</p> 

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в сущности Client (см. рисунок 6).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956864-e0fa4561-db66-42cb-873f-9c54699e8641.PNG"</p>
<p align="center">Рисунок 6 -Проверка работы методов CRUD</p> 

1) Create позволяет добавлять новые строки в вашу таблицу (см. рисунок 7).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956875-4381d2c0-b689-48f2-8095-02e7ac165777.PNG"</p>
<p align="center">Рисунок 7 - Окно метода создания</p> 

Ввод необходимых данных об покупателе в соответствующие поля (см. рисунок 8).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956897-899927fe-1e86-42a4-a7ad-eda8bf21dae2.PNG"</p>
  <p align="center">Рисунок 8 - Работа с методом создания</p>
  
  После успешного выполнения операции сервер выдаёт ответ (см. рисунок 9).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956936-7be31874-8f6e-4e11-bd5d-5efa339a8b48.PNG"</p>
  <p align="center">Рисунок 9 - Результат выполнения операции создания</p> 
  
  2) Функция чтения Read похожа на функцию поиска, поскольку позволяет извлекать определенные записи и считывать их значения (см. рисунок 10).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956945-ded71b33-5ddd-4fab-ad76-c8bcc780b6e7.PNG"</p>
  <p align="center">Рисунок 10 - Окно функции чтения</p> 
  
  Считывание информации об уже созданном клиенте по его Id (см. рисунок 11).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956958-d0b6fe76-af0f-4705-85ab-b837c4947957.PNG"</p>
  <p align="center">Рисунок 11 - Работа с методом чтения</p> 
  
  После выполнения операции сервер выдаёт информацию о клиенте, которая была создана в Create (см. рисунок 12).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956973-99223e8d-f952-411e-81c4-6ea9862d5c52.PNG"</p>
  <p align="center">Рисунок 12 - Результат выполнения операции чтения</p> 
  
  3) Update, редактирование записи (см. рисунок 13). Используется для изменения существующих записей в базе данных.
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956985-9148557e-0846-4822-9bb4-cb47204f9914.PNG"</p>
  <p align="center">Рисунок 13 - Окно метода обновления</p> 
  
  Изменение информации о клиенте, для этого сначала нужно ввести его номер и затем новые данные (см. рисунок 14).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146956998-0cc75816-3118-41d8-b91b-1c2522bb3958.PNG"</p>
  <p align="center">Рисунок 14 - Работа с методом обновления</p> 
  
  После выполнения операции сервер выдаёт новую информацию о том же клиенте (см. рисунок 15).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957024-3d84c045-69b6-4bb9-8d03-88e6107027cf.PNG"</p>
  <p align="center">Рисунок 15 - Результат выполнения операции обновления</p> 
  
  Функцией read проверка вышеуказанной операции. После срабатывания сервер выдает новую информацию о клиенте (см. рисунок 16).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957050-8e1601f8-4573-4713-99c1-66b05211e54f.PNG"</p>
  <p align="center">Рисунок 16 - Результат выполнения операции чтения после обновления данных</p> 
  
  4) Delete - используется для удаления записи по Id. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см. рисунок 17).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957061-b1eae035-f071-40f3-9942-18fe3248c472.PNG"</p>
  <p align="center">Рисунок 17 - Окно метода удаления</p> 
  
  Удаление клиента по его Id (см. рисунок 18).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957155-86b97569-b7fc-4670-80b5-d93e7e1da42e.PNG"</p>
  <p align="center">Рисунок 18 - Работа с методом удаления</p> 
  
  После выполнения операции ответ сервера (см. рисунок 19).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957177-0a7fd6c0-59ba-48b0-8104-a27f1359b5f9.PNG"</p>
  <p align="center">Рисунок 19 - Раезультат выполнения метода удаления</p> 
  
  Проверка вышеописанного действия с помощью read, считывание информацию об удалённом клиенте (см. рисунок 20).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957187-f2e54174-84f5-4648-96fb-f6af529dbb6a.PNG"</p>
  <p align="center">Рисунок 20 - Работа с операцией чтения</p> 
  
  После срабатывания программа не выдаёт информации об этом клиенте (см. рисунок 21).
<p align="center">
  <img src = "https://user-images.githubusercontent.com/90554731/146957198-75996dd6-c9fb-4135-92ac-72b79aa61753.PNG"</p>
  <p align="center">Рисунок 21 - Результат выполнения операции чтения после удаления данных</p>

***
## Заключение <a name="заключение"></a>
В рамках данной работы была разработана информационная система онлайн-регистратуры частной клиники. Для этого сначала были определены внешние системы, влияющие на решение, а также системы, учитываемые при формировании допустимых решений; цели, требования, условия, затем была проведена проверка полноты и достоверности исходных данных, и наконец, были оценены реальные последствия. В перспективе предполагается привязаться проект к базе данных, добавить методы для увеличения спектра возможностей работы на сайте.

***
## Cписок литературы <a name="список_литературы"></a>  
