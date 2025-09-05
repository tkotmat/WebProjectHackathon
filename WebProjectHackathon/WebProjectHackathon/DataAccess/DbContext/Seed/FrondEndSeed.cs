using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.DbContext.Seed
{
    public static class FrondEndSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // CircleContextPagesInfo
            modelBuilder.Entity<CircleContextPagesInfoEntity>().HasData(
                new CircleContextPagesInfoEntity
                {
                    Id = 1,
                    IdContextHomePages = 1,
                    Title = "Вивчити основи веб-розробки",
                    Description = "Основи HTML, CSS, JavaScript. Розуміння структури веб-сторінок."
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 2,
                    IdContextHomePages = 1,
                    Title = "Освоїти сучасні фреймворки та бібліотеки",
                    Description = "React, Vue або Angular. Компонентний підхід, SPA, state management."
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 3,
                    IdContextHomePages = 1,
                    Title = "Вивчити інструменти розробника",
                    Description = "Chrome DevTools, Postman, Git, Webpack. Налагодження та оптимізація."
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 4,
                    IdContextHomePages = 1,
                    Title = "Робота з API",
                    Description = "REST API, GraphQL. Запити до серверів, обробка JSON."
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 5,
                    IdContextHomePages = 1,
                    Title = "Створити портфоліо",
                    Description = "Верстка проектів, хостинг, підключення реальних API."
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 6,
                    IdContextHomePages = 1,
                    Title = "Отримати перший комерційний досвід",
                    Description = "Фріланс, стажування, open-source проекти. Робота в команді."
                }
            );

            // MainPanelContext
            modelBuilder.Entity<MainPanelContextEntity>().HasData(
                // CircleContextPagesInfoId = 1
                new MainPanelContextEntity { Id = 1, CircleContextPagesInfoEntityId = 1, Title = "HTML та CSS", Context = "Основи створення веб-сторінок: структура HTML-документів, основні теги та атрибути. Використання CSS для стилізації елементів, верстка сторінок та адаптивний дизайн.", Url = "https://developer.mozilla.org/uk/docs/Learn9" },
                new MainPanelContextEntity { Id = 2, CircleContextPagesInfoEntityId = 1, Title = "JavaScript та DOM", Context = "Основи мови програмування JavaScript: змінні, типи даних, функції, цикли та умови. Робота з DOM (Document Object Model), події та маніпуляція HTML-елементами.", Url = "https://developer.mozilla.org/uk/docs/Web/JavaScript" },
                new MainPanelContextEntity { Id = 3, CircleContextPagesInfoEntityId = 1, Title = "Основи Backend-розробки", Context = "Знайомство з серверною частиною веб-розробки. Основи роботи з базами даних (SQL, NoSQL), сервери, API та бекенд-фреймворки, наприклад, ASP.NET MVC.", Url = "https://learn.microsoft.com/uk-ua/aspnet/mvc/" },
                new MainPanelContextEntity { Id = 4, CircleContextPagesInfoEntityId = 1, Title = "Контроль версій та розгортання", Context = "Використання систем контролю версій, таких як Git. Основи хостингу, деплою веб-додатків, робота з хмарними платформами (Azure, AWS).", Url = "https://docs.github.com/uk/get-started" },

                // CircleContextPagesInfoId = 2
                new MainPanelContextEntity { Id = 5, CircleContextPagesInfoEntityId = 2, Title = "React.js", Context = "Популярна бібліотека для створення інтерфейсів користувача. Основи роботи з компонентами, станами (state), пропсами (props) та хуками (hooks). Знайомство з JSX та віртуальним DOM.", Url = "https://react.dev/" },
                new MainPanelContextEntity { Id = 6, CircleContextPagesInfoEntityId = 2, Title = "Angular", Context = "Фреймворк від Google для побудови масштабованих SPA (Single Page Applications). Основи TypeScript, робота з компонентами, модулями, сервісами та RxJS.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 7, CircleContextPagesInfoEntityId = 2, Title = "Vue.js", Context = "Простий у засвоєнні фреймворк для створення реактивних інтерфейсів. Робота з шаблонами, директивами, Vue Router та Vuex.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 8, CircleContextPagesInfoEntityId = 2, Title = "ASP.NET Core", Context = "Сучасний бекенд-фреймворк від Microsoft для створення веб-додатків, API та мікросервісів. Вивчення контролерів, middleware, Entity Framework Core та автентифікації.", Url = "https://learn.microsoft.com/en-us/aspnet/core/" },

                // CircleContextPagesInfoId = 3
                new MainPanelContextEntity { Id = 9, CircleContextPagesInfoEntityId = 3, Title = "Chrome DevTools", Context = "Набір інструментів для налагодження веб-сторінок у браузері Google Chrome. Дозволяє аналізувати HTML, CSS, JavaScript, мережеві запити, продуктивність та помилки.", Url = "https://developer.mozilla.org/uk/docs/Learn9" },
                new MainPanelContextEntity { Id = 10, CircleContextPagesInfoEntityId = 3, Title = "Postman", Context = "Популярний інструмент для тестування API. Дозволяє надсилати HTTP-запити, перевіряти відповіді серверів, створювати колекції запитів та автоматизувати тестування.", Url = "https://developer.mozilla.org/uk/docs/Web/JavaScript" },
                new MainPanelContextEntity { Id = 11, CircleContextPagesInfoEntityId = 3, Title = "Webpack", Context = "Модульний збирач JavaScript-додатків, що оптимізує код, обробляє CSS, зображення та інші ресурси. Вивчення конфігурації, лоадерів та плагінів.", Url = "https://learn.microsoft.com/uk-ua/aspnet/mvc/" },
                new MainPanelContextEntity { Id = 12, CircleContextPagesInfoEntityId = 3, Title = "Docker", Context = "Платформа для контейнеризації, що дозволяє створювати, розгортати та керувати ізольованими середовищами для додатків. Основи Docker Compose, Docker Images та контейнерів.", Url = "https://docs.github.com/uk/get-started" },

                // CircleContextPagesInfoId = 4
                new MainPanelContextEntity { Id = 13, CircleContextPagesInfoEntityId = 4, Title = "Основи REST API", Context = "Знайомство з принципами REST (Representational State Transfer), методами HTTP-запитів (GET, POST, PUT, DELETE), статус-кодами та форматами обміну даними (JSON, XML).", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 14, CircleContextPagesInfoEntityId = 4, Title = "Fetch та Axios", Context = "Робота з API у JavaScript: використання fetch() та бібліотеки Axios для виконання HTTP-запитів, обробка відповідей сервера та помилок.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 15, CircleContextPagesInfoEntityId = 4, Title = "API з ASP.NET Core", Context = "Розробка API за допомогою ASP.NET Core: створення контролерів, обробка запитів, використання JSON Web Token (JWT) для автентифікації та взаємодія з базами даних через Entity Framework Core.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 16, CircleContextPagesInfoEntityId = 4, Title = "GraphQL альтернатива REST", Context = "Після підготовки варто активно шукати можливості: Джуніор-позиції та стажування – пошук у LinkedIn, на сайтах компаній, Нетворкінг – участь у мітапах, Telegram-чатах для айтішників, Кар'єрний ріст – пробувати нові технології, покращувати софт-скіли", Url = "https://source4.com" },

                // CircleContextPagesInfoId = 5
                new MainPanelContextEntity { Id = 17, CircleContextPagesInfoEntityId = 5, Title = "Вибір платформи та структури", Context = "Портфоліо можна створити у вигляді окремого веб-сайту або розмістити на платформах типу GitHub Pages, Netlify або Vercel. Важливо продумати структуру: Головна сторінка (про себе, фото, контакти),Проекти (список з описом та посиланнями).", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 18, CircleContextPagesInfoEntityId = 5, Title = "Технології для розробки портфоліо", Context = "HTML, CSS, JavaScript – для створення статичного сайту, React.js, Vue.js або Angular – для динамічного портфоліо,Bootstrap або Tailwind CSS – для швидкого стилізування.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 19, CircleContextPagesInfoEntityId = 5, Title = "Додавання проектів", Context = "Важливо додати кілька проєктів, які демонструють навички. Для кожного проекту: Назва та короткий опис, Використані технології, Скріншоти або демо-версія.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 20, CircleContextPagesInfoEntityId = 5, Title = "Оптимізація та SEO", Context = "Щоб портфоліо виглядало професійно: Використовуй адаптивний дизайн, Додай анімації або інтерактивні елементи, Використовуй мета-теги та SEO-практики.", Url = "https://source4.com" },

                // CircleContextPagesInfoId = 6
                new MainPanelContextEntity { Id = 21, CircleContextPagesInfoEntityId = 6, Title = "Фріланс-платформи", Context = "Один із найпростіших способів отримати перші комерційні замовлення – почати працювати на фрілансі. Реєструйся на платформах, заповнюй профіль і пропонуй свої послуги.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 22, CircleContextPagesInfoEntityId = 6, Title = "Open Source та волонтерські проєкти", Context = "Допоможи некомерційним організаціям або внеси вклад у Open Source-проєкти. Це не лише корисний досвід, але й можливість створити портфоліо та отримати рекомендації.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 23, CircleContextPagesInfoEntityId = 6, Title = "Стажування та джуніор-вакансії", Context = "Шукай стажування або роботу на позицію Junior Developer. Деякі компанії готові брати початківців без досвіду, якщо є базові навички.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 24, CircleContextPagesInfoEntityId = 6, Title = "Нетворкінг та знайомства", Context = "Знайомся з іншими розробниками та шукай можливості через знайомих. Відвідуй IT-конференції, мітапи, вебінари.", Url = "https://source4.com" }
            );
        }
    }
}
