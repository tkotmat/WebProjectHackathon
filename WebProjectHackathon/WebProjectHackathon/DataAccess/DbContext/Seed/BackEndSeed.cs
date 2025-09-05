using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.DbContext.Seed
{
    public static class BackEndSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // CircleContextPagesInfo (Id начиная с 7)
            modelBuilder.Entity<CircleContextPagesInfoEntity>().HasData(
                new CircleContextPagesInfoEntity
                {
                    Id = 7,
                    IdContextHomePages = 2,
                    Title = "Вивчення мови програмування",
                    Description = "JavaScript (Node.js), Python, PHP, Java або C#"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 8,
                    IdContextHomePages = 2,
                    Title = "Робота з базами даних",
                    Description = "SQL (PostgreSQL, MySQL) або NoSQL (MongoDB, Firebase)"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 9,
                    IdContextHomePages = 2,
                    Title = "Архітектура та серверні технології",
                    Description = "MVC, REST API, GraphQL. Аутентифікація (JWT, OAuth)"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 10,
                    IdContextHomePages = 2,
                    Title = "DevOps та хмарні технології",
                    Description = "Docker, Kubernetes, AWS, CI/CD"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 11,
                    IdContextHomePages = 2,
                    Title = "Практика та працевлаштування",
                    Description = "Створення портфоліо (GitHub). Стажування, перша робота"
                }
            );

            // MainPanelContext
            // CircleContextPagesInfoId = 8
            modelBuilder.Entity<MainPanelContextEntity>().HasData(
                new MainPanelContextEntity { Id = 25, CircleContextPagesInfoEntityId = 7, Title = "Вибір мови програмування", Context = "Перед початком навчання варто визначитися з мовою програмування. Вибір залежить від мети: Python, JavaScript, Java, C#, C++, Swift, Kotlin", Url = "https://devdocs.io/" },
                new MainPanelContextEntity { Id = 26, CircleContextPagesInfoEntityId = 7, Title = "Основи синтаксису", Context = "Після вибору мови потрібно освоїти її базові конструкції: Змінні та типи даних, Оператори та умови, Цикли та функції", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 27, CircleContextPagesInfoEntityId = 7, Title = "Робота з бібліотеками та фреймворками", Context = "Бібліотеки та фреймворки допомагають пришвидшити розробку: Django, Flask – для бекенду, Spring Boot – для Java-додатків", Url = "https://docs.djangoproject.com/" },
                new MainPanelContextEntity { Id = 28, CircleContextPagesInfoEntityId = 7, Title = "Практика та створення проєктів", Context = "Кращий спосіб вивчити програмування – практика: Розв’язуйте задачі на алгоритми, Беріть участь у хакатонах, Розробляйте власні проєкти", Url = "https://source2.com" },

                // CircleContextPagesInfoId = 8
                new MainPanelContextEntity { Id = 29, CircleContextPagesInfoEntityId = 8, Title = "Основи баз даних", Context = "База даних – це організований набір даних, що зберігається та керується системою управління базами даних (СУБД). Основні поняття: Реляційні БД (SQL) – MySQL, PostgreSQL. Нереляційні БД (NoSQL) – MongoDB, Redis, Cassandra та Запити SQL – SELECT, INSERT, UPDATE, DELETE", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 30, CircleContextPagesInfoEntityId = 8, Title = "Проєктування баз даних", Context = "Щоб створити ефективну БД, потрібно враховувати: Нормалізацію (запобігання дублюванню даних), Зв’язки між таблицями (один-до-одного, один-до-багатьох), Індекси для пришвидшення пошуку даних", Url = "https://vertabelo.com/" },
                new MainPanelContextEntity { Id = 31, CircleContextPagesInfoEntityId = 8, Title = "Робота з реляційними та NoSQL базами", Context = "Реляційні БД використовують SQL-запити, тоді як NoSQL підходять для гнучкого зберігання даних: MySQL/PostgreSQL – класичні реляційні БД, Redis – ключ-значення для кешування, Firebase – хмарне сховище", Url = "https://www.postgresql.org/docs/" },
                new MainPanelContextEntity { Id = 32, CircleContextPagesInfoEntityId = 8, Title = "Оптимізація та безпека баз даних", Context = "Щоб база працювала швидко та безпечно, потрібно: Використовувати індекси для швидкого пошуку, Уникати надмірної вкладеності запитів, Захищати дані від SQL-ін’єкцій", Url = "https://source4.com" },

                // CircleContextPagesInfoId = 9
                new MainPanelContextEntity { Id = 33, CircleContextPagesInfoEntityId = 9, Title = "Основи архітектури програмного забезпечення", Context = "Архітектура програмного забезпечення визначає структуру та взаємодію компонентів системи. Основні підходи: Монолітна архітектура – вся логіка в одному застосунку", Url = "https://microservices.io/" },
                new MainPanelContextEntity { Id = 34, CircleContextPagesInfoEntityId = 9, Title = "Серверні технології та веб-сервери", Context = "Серверні технології використовуються для обробки запитів та управління даними. Популярні технології: Apache, Nginx – веб-сервери для обробки HTTP-запитів, Django, Flask – Python-фреймворки для бекенду", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 35, CircleContextPagesInfoEntityId = 9, Title = "Бази даних у серверних застосунках", Context = "Сервер обробляє запити до бази даних. Основні підходи: SQL (MySQL, PostgreSQL) – для структурованих даних, NoSQL (MongoDB, Redis) – для гнучких та швидких запитів", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 36, CircleContextPagesInfoEntityId = 9, Title = "Масштабування, балансування навантаження та безпека", Context = "Щоб система була стійкою, потрібно: Балансування навантаження (Load Balancer, Nginx), Хмарні рішення (AWS, Google Cloud, Azure), Безпека (HTTPS, JWT, OAuth)", Url = "https://aws.amazon.com/" },

                // CircleContextPagesInfoId = 10
                new MainPanelContextEntity { Id = 37, CircleContextPagesInfoEntityId = 10, Title = "Основи DevOps", Context = "DevOps – це методологія, що поєднує розробку (Development) та операційну діяльність (Operations).", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 38, CircleContextPagesInfoEntityId = 10, Title = "Інструменти DevOps", Context = "Автоматизація – ключовий аспект DevOps. Основні інструменти: Контейнери – Docker, Podman, Jenkins, GitLab CI.", Url = "https://kubernetes.io/" },
                new MainPanelContextEntity { Id = 39, CircleContextPagesInfoEntityId = 10, Title = "Хмарні технології", Context = "Хмарні платформи надають інструменти для масштабування та керування інфраструктурою: AWS (Amazon Web Services)", Url = "https://learn.microsoft.com/en-us/azure/" },
                new MainPanelContextEntity { Id = 40, CircleContextPagesInfoEntityId = 10, Title = "Моніторинг та безпека", Context = "Для стабільної роботи системи важливо впровадити моніторинг та безпеку: Моніторинг логів та продуктивності", Url = "https://source4.com" },

                // CircleContextPagesInfoId = 11
                new MainPanelContextEntity { Id = 41, CircleContextPagesInfoEntityId = 11, Title = "Практичний досвід та створення проєктів", Context = "Для успішного працевлаштування важливо мати реальний досвід роботи з технологіями. Особисті проєкти, Open Source, Фріланс, Хакатони та конкурси.", Url = "https://www.codewars.com/" },
                new MainPanelContextEntity { Id = 42, CircleContextPagesInfoEntityId = 11, Title = "Написання резюме та портфоліо", Context = "Щоб зацікавити роботодавця, потрібно грамотно оформити резюме та портфоліо: Резюме, Портфоліо, LinkedIn.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 43, CircleContextPagesInfoEntityId = 11, Title = "Підготовка до співбесіди", Context = "Для успішного проходження співбесід потрібно: Алгоритмічні завдання, Питання щодо структур даних та алгоритмів, Підготовка до технічної співбесіди.", Url = "https://www.hackerrank.com/" },
                new MainPanelContextEntity { Id = 44, CircleContextPagesInfoEntityId = 11, Title = "Пошук роботи та перші кроки в кар'єрі", Context = "Джуніор-позиції та стажування – пошук у LinkedIn, на сайтах компаній, Нетворкінг, Кар'єрний ріст – пробувати нові технології, покращувати софт-скіли", Url = "https://source4.com" }
            );
        }
    }
}
