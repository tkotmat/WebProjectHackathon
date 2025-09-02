using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

public class DataSet
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContextHomePagesEntity>().HasData(
            new ContextHomePagesEntity
            {
                Id = 1,
                Title = "Frontend-розробник",
                Description = "Створює зовнішній інтерфейс сайтів та веб-додатків. Відповідає за вигляд," +
                              " інтерактивність та коректну роботу веб-сторінок на різних пристроях. Використовує HTML, CSS, JavaScript та сучасні фреймворки."
            },
            new ContextHomePagesEntity
            {
                Id = 2,
                Title = "Backend-розробник",
                Description = "Розробляє логіку роботи сервера, баз даних та API, які забезпечують функціонування сайту." +
                              " Працює з мовами програмування, такими як Python, PHP, Java, та базами даних MySQL або PostgreSQL."
            },
            new ContextHomePagesEntity
            {
                Id = 3,
                Title = "HR Manager",
                Description = "Шукає та адаптує нових спеціалістів, створює комфортну атмосферу у команді," +
                              " проводить співбесіди та допомагає з розвитком персоналу. Відповідає за побудову сильної корпоративної культури."
            },
            new ContextHomePagesEntity
            {
                Id = 4,
                Title = "UX/UI Дизайнер",
                Description = "Проектує інтерфейси, роблячи їх зручними, доступними та привабливими для користувачів." +
                              " Використовує інструменти дизайну, такі як Figma, Adobe XD, та аналізує поведінку користувачів для покращення взаємодії."
            }
        );
        modelBuilder.Entity<CircleContextPagesInfoEntity>().HasData(
            // Frond-end
            new  CircleContextPagesInfoEntity
            {
                Id = 1,
                Title = "Вивчити основи веб-розробки",
                Description = "Основи HTML, CSS, JavaScript. Розуміння структури веб-сторінок.",
                
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 2,
                Title = "Освоїти сучасні фреймворки та бібліотеки",
                Description = "React, Vue або Angular. Компонентний підхід, SPA, state management.",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 3,
                Title = "Вивчити інструменти розробника",
                Description = "Chrome DevTools, Postman, Git, Webpack. Налагодження та оптимізація.",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 4,
                Title = "Створити портфоліо",
                Description = "Верстка проектів, хостинг, підключення реальних API.",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 5,
                Title = "Отримати перший комерційний досвід",
                Description = "Фріланс, стажування, open-source проекти. Робота в команді.",
            },
            // back-end
            new  CircleContextPagesInfoEntity
            {
                Id = 6,
                Title = "Вивчення мови програмування",
                Description = "JavaScript (Node.js), Python, PHP, Java або C#",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 7,
                Title = "Робота з базами даних",
                Description = "SQL (PostgreSQL, MySQL) або NoSQL (MongoDB, Firebase)",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 8,
                Title = "Архітектура та серверні технології",
                Description = "MVC, REST API, GraphQL. Аутентифікація (JWT, OAuth)",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 9,
                Title = "DevOps та хмарні технології",
                Description = "Docker, Kubernetes, AWS, CI/CD",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 10,
                Title = "Практика та працевлаштування",
                Description = "Створення портфоліо (GitHub). Стажування, перша робота",
            },
            //HR
            new  CircleContextPagesInfoEntity
            {
                Id = 11,
                Title = "Менеджмент, психологія, HR-курси",
                Description = "Вивчення теорії",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 12,
                Title = "Освоєння HR-інструментів",
                Description = "LinkedIn, Work.ua, Djinni, ATS-системи (Workable, Greenhouse)",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 13,
                Title = "Розвиток комунікаційних навичок",
                Description = "Проведення співбесід Робота з конфліктами",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 14,
                Title = "Знання трудового законодавства",
                Description = "Оформлення документів",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 15,
                Title = "Практика та працевлаштування",
                Description = "Стажування у HR-відділі",
            },
            //UI/UX
            new  CircleContextPagesInfoEntity
            {
                Id = 16,
                Title = "Візуальна ієрархія",
                Description = "Колір, типографіка, розташування. Контраст, баланс, ритм. Використання сіток (grid system).",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 17,
                Title = "UX-дослідження",
                Description = "Аналіз поведінки, тестування макетів (Google Analytics, Hotjar, A/B-тестування).",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 18,
                Title = "Інструменти",
                Description = "Figma, Adobe XD, Sketch – створення UI, прототипування, дизайн-системи.",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 19,
                Title = "Код для дизайнерів",
                Description = "Основи HTML, CSS, змінні, шрифти, кольорові схеми.",
            },
            new  CircleContextPagesInfoEntity
            {
                Id = 20,
                Title = "Портфоліо",
                Description = "3-5 кейсів у Behance, Dribbble.",
            }
        );
    }
}
