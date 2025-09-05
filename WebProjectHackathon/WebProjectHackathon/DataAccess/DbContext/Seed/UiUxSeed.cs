using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.DbContext.Seed
{
    public static class UiUxSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CircleContextPagesInfoEntity>().HasData(
                new CircleContextPagesInfoEntity
                {
                    Id = 17,
                    IdContextHomePages = 4,
                    Title = "Візуальна ієрархія",
                    Description = "Колір, типографіка, розташування. Контраст, баланс, ритм. Використання сіток (grid system).",
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 18,
                    IdContextHomePages = 4,
                    Title = "UX-дослідження",
                    Description = "Аналіз поведінки, тестування макетів (Google Analytics, Hotjar, A/B-тестування).",
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 19,
                    IdContextHomePages = 4,
                    Title = "Інструменти",
                    Description = "Figma, Adobe XD, Sketch – створення UI, прототипування, дизайн-системи.",
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 20,
                    IdContextHomePages = 4,
                    Title = "Код для дизайнерів",
                    Description = "Основи HTML, CSS, змінні, шрифти, кольорові схеми.",
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 21,
                    IdContextHomePages = 4,
                    Title = "Портфоліо",
                    Description = "3-5 кейсів у Behance, Dribbble.",
                }
            );
            modelBuilder.Entity<MainPanelContextEntity>().HasData(
                // CircleContextPagesInfoId = 17
                new MainPanelContextEntity { Id = 65,CircleContextPagesInfoEntityId = 17,Title = "Візуальна ієрархія",Context = "Організація елементів інтерфейсу за рівнем важливості, використовуючи розмір, колір, контраст і простір.",Url = "https://source1.com"},
                new MainPanelContextEntity { Id = 66,CircleContextPagesInfoEntityId = 17,Title = "Типографіка в UI/UX",Context = "Вибір шрифтів, їх поєднання, розмір та інтервали для зручності читання і візуальної гармонії.",Url = "https://source2.com"},
                new MainPanelContextEntity { Id = 67,CircleContextPagesInfoEntityId = 17,Title = "Колір та контраст",Context = "Використання кольорової палітри для передачі настрою, підвищення зручності використання та створення акцентів.", Url = "https://source3.com"},
                new MainPanelContextEntity { Id = 68,CircleContextPagesInfoEntityId = 17,Title = "Сітки та вирівнювання",Context = "Використання сіткових систем для впорядкування контенту та забезпечення гармонійного розташування елементів.",Url = "https://source4.com"},
                // CircleContextPagesInfoId = 18
                new MainPanelContextEntity { Id = 69,CircleContextPagesInfoEntityId = 18,Title = "Аналіз цільової аудиторії",Context = "Визначення потреб, поведінки та очікувань користувачів за допомогою опитувань, інтерв’ю та аналізу даних.",Url = "https://source1.com"},
                new MainPanelContextEntity { Id = 70,CircleContextPagesInfoEntityId = 18,Title = "Юзабіліті-тестування",Context = "Перевірка зручності використання продукту через спостереження за реальними користувачами та виявлення проблем у взаємодії.",Url = "https://source2.com"},
                new MainPanelContextEntity { Id = 71,CircleContextPagesInfoEntityId = 18,Title = "Створення персон користувачів",Context = "Розробка узагальнених портретів користувачів для кращого розуміння їхніх цілей, мотивації та болей.",Url = "https://source3.com"},
                new MainPanelContextEntity { Id = 72,CircleContextPagesInfoEntityId = 18,Title = "Картування користувацького шляху (User Journey)",Context = "Візуалізація взаємодії користувача з продуктом, виявлення проблемних точок і можливостей для покращення UX.",Url = "https://source4.com"},
                // CircleContextPagesInfoId = 19
                new MainPanelContextEntity { Id = 73,CircleContextPagesInfoEntityId = 19,Title = "Figma",Context = "Популярний інструмент для створення макетів, прототипування та спільної роботи над дизайном.",Url = "https://source1.com"},
                new MainPanelContextEntity { Id = 74,CircleContextPagesInfoEntityId = 19,Title = "Adobe XD",Context = "Програма для проєктування інтерфейсів, створення інтерактивних прототипів і тестування UX-рішень.",Url = "https://source2.com"},
                new MainPanelContextEntity { Id = 75,CircleContextPagesInfoEntityId = 19,Title = "Sketch",Context = "Інструмент для розробки UI-дизайну, що використовується переважно на macOS, із широкими можливостями плагінів.",Url = "https://source3.com"},
                new MainPanelContextEntity { Id = 76,CircleContextPagesInfoEntityId = 19,Title = "Miro",Context = "Онлайн-дошка для командної роботи, мозкового штурму, створення схем користувацького шляху та UX-досліджень.",Url = "https://source4.com"},
                // CircleContextPagesInfoId = 20
                new MainPanelContextEntity {Id = 77,CircleContextPagesInfoEntityId = 20,Title = "Основи HTML та CSS",Context = "Вивчення базової структури веб-сторінок, стилізація елементів та створення адаптивного дизайну.",Url = "https://source1.com"},
                new MainPanelContextEntity {Id = 78,CircleContextPagesInfoEntityId = 20,Title = "CSS-анімації та переходи",Context = "Додавання динаміки до інтерфейсу за допомогою анімацій, плавних переходів і ефектів наведення.",Url = "https://source2.com"},
                new MainPanelContextEntity { Id = 79,CircleContextPagesInfoEntityId = 20,Title = "Основи JavaScript для UI",Context = "Використання JavaScript для інтерактивності, таких як модальні вікна, випадаючі меню та динамічний контент.",Url = "https://source3.com"},
                new MainPanelContextEntity { Id = 80,CircleContextPagesInfoEntityId = 20,Title = "Фреймворки та бібліотеки (Bootstrap, Tailwind CSS)",Context = "Використання готових компонентів і стилів для прискорення розробки та уніфікації дизайну.",Url = "https://source4.com"},
                // CircleContextPagesInfoId = 21
                new MainPanelContextEntity { Id = 81,CircleContextPagesInfoEntityId = 21,Title = "Демонстрація проєктів",Context = "Включення кількох ваших найкращих проєктів, які демонструють ваші навички в дизайні, дослідженнях та прототипуванні.",Url = "https://source1.com"},
                new MainPanelContextEntity { Id = 82,CircleContextPagesInfoEntityId = 21,Title = "Опис процесу роботи",Context = "Документування етапів роботи над проєктами, від досліджень до реалізації, щоб показати ваше розуміння процесу UX/UI-дизайну.",Url = "https://source2.com"},
                new MainPanelContextEntity { Id = 83,CircleContextPagesInfoEntityId = 21,Title = "Інтерактивні прототипи",Context = "Додавання інтерактивних прототипів, щоб потенційні клієнти могли взаємодіяти з вашим дизайном і бачити його в дії.",Url = "https://source3.com"},
                new MainPanelContextEntity { Id = 84,CircleContextPagesInfoEntityId = 21,Title = "Відгуки та рекомендації",Context = "Додавання відгуків клієнтів або колег, які можуть підтвердити вашу професійну кваліфікацію та досвід.",Url = "https://source4.com"}
            );
        }
    }
}
