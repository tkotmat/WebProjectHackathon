using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.DbContext.Seed
{
    public static class HrSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // CircleContextPagesInfoEntity (начинаем с Id = 12)
            modelBuilder.Entity<CircleContextPagesInfoEntity>().HasData(
                new CircleContextPagesInfoEntity
                {
                    Id = 12,
                    IdContextHomePages = 3,
                    Title = "Менеджмент, психологія, HR-курси",
                    Description = "Вивчення теорії"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 13,
                    IdContextHomePages = 3,
                    Title = "Освоєння HR-інструментів",
                    Description = "LinkedIn, Work.ua, Djinni, ATS-системи (Workable, Greenhouse)"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 14,
                    IdContextHomePages = 3,
                    Title = "Розвиток комунікаційних навичок",
                    Description = "Проведення співбесід та робота з конфліктами"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 15,
                    IdContextHomePages = 3,
                    Title = "Знання трудового законодавства",
                    Description = "Оформлення документів"
                },
                new CircleContextPagesInfoEntity
                {
                    Id = 16,
                    IdContextHomePages = 3,
                    Title = "Практика та працевлаштування",
                    Description = "Стажування у HR-відділі"
                }
            );

            // MainPanelContextEntity ( Id = 45,)
            modelBuilder.Entity<MainPanelContextEntity>().HasData(
                // CircleContextPagesInfoId = 12
                new MainPanelContextEntity { Id = 45, CircleContextPagesInfoEntityId = 12, Title = "HR-менеджер", Context = "Основи управління персоналом, психологія роботи з людьми та підбір кадрів: Основи менеджменту: як знайти, мотивувати та утримати співробітників.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 46, CircleContextPagesInfoEntityId = 12, Title = "Освоєння HR-інструментів", Context = "Знайомство з платформами для пошуку кандидатів та автоматизація рекрутингу: LinkedIn, Work.ua, Djinni: пошук та аналіз профілів, ATS-системи (Workable, Greenhouse, BambooHR): автоматизація процесу найму.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 47, CircleContextPagesInfoEntityId = 12, Title = "Розвиток комунікаційних навичок", Context = "Навички проведення співбесід та вирішення конфліктів у командах: Підготовка ефективних питань та оцінка відповідей кандидатів, визначення мотивації та рівня професіоналізму претендента.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 48, CircleContextPagesInfoEntityId = 12, Title = "Знання трудового законодавства", Context = "Оформлення документації та правові аспекти працевлаштування: Контракти, політики компанії, NDA, законодавчі вимоги щодо працевлаштування та оформлення співробітників.", Url = "https://source4.com" },
                // CircleContextPagesInfoId = 13
                new MainPanelContextEntity { Id = 49, CircleContextPagesInfoEntityId = 13, Title = "Основи HR-аналізу", Context = "Вивчення методів збору та аналізу даних про співробітників для оцінки їхньої ефективності та побудови метрик продуктивності.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 50, CircleContextPagesInfoEntityId = 13, Title = "Підбір та найм персоналу", Context = "Використання інструментів для автоматизації процесів підбору кандидатів, таких як HR-боти та онлайн-платформи для співбесід та тестування.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 51, CircleContextPagesInfoEntityId = 13, Title = "Аналіз залученості співробітників", Context = "Застосування інструментів для вимірювання рівня залученості та визначення факторів, що впливають на мотивацію та утримання співробітників.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 52, CircleContextPagesInfoEntityId = 13, Title = "HR-автоматизація та ІТ-інструменти", Context = "Освоєння програмних рішень для автоматизації HR-процесів, включаючи розрахунок заробітної плати, управління відпустками та лікарняними.", Url = "https://source4.com" },
                // CircleContextPagesInfoId = 14
                new MainPanelContextEntity { Id = 53, CircleContextPagesInfoEntityId = 14, Title = "Основи ефективної комунікації", Context = "Вивчення принципів та технік ефективного спілкування, зокрема активного слухання та чіткої передачі інформації.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 54, CircleContextPagesInfoEntityId = 14, Title = "Управління конфліктами", Context = "Розвиток навичок розв'язання конфліктних ситуацій у команді, використання технік для конструктивного вирішення суперечок.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 55, CircleContextPagesInfoEntityId = 14, Title = "Командна комунікація", Context = "Опанування стратегій для ефективної роботи в команді, в тому числі обговорення ідей, обміну інформацією та підтримки колег.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 56, CircleContextPagesInfoEntityId = 14, Title = "Міжособистісні комунікації", Context = "Розвиток навичок взаємодії з різними людьми, включаючи встановлення контактів, створення довірливих відносин і адаптацію до різних стилів спілкування.", Url = "https://source4.com" },
                // CircleContextPagesInfoId = 15
                new MainPanelContextEntity { Id = 57, CircleContextPagesInfoEntityId = 15, Title = "Основи трудового законодавства", Context = "Вивчення основних положень трудового кодексу та законів, що регулюють права та обов'язки роботодавців і працівників.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 58, CircleContextPagesInfoEntityId = 15, Title = "Оформлення трудових відносин", Context = "Опанування процесами укладання трудових договорів, реєстрації працівників, а також розуміння різних видів трудових контрактів.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 59, CircleContextPagesInfoEntityId = 15, Title = "Права та обов'язки працівників і роботодавців", Context = "Знання прав та обов'язків сторін трудових відносин, включаючи питання оплати праці, відпусток, лікарняних та дисциплінарних санкцій.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 60, CircleContextPagesInfoEntityId = 15, Title = "Урегулювання трудових суперечок", Context = "Ознайомлення з процедурами вирішення трудових спорів, звернення до органів праці та судових установ, а також медіація в трудових питаннях.", Url = "https://source4.com" },
                // CircleContextPagesInfoId = 16
                new MainPanelContextEntity { Id = 61, CircleContextPagesInfoEntityId = 16, Title = "Пошук та підбір роботи", Context = "Опанування методів ефективного пошуку роботи, створення резюме та супровідного листа, а також підготовка до співбесід.", Url = "https://source1.com" },
                new MainPanelContextEntity { Id = 62, CircleContextPagesInfoEntityId = 16, Title = "Процес адаптації на новому місці роботи", Context = "Вивчення кроків для успішної адаптації на новій посаді, знайомство з корпоративною культурою та вимогами компанії.", Url = "https://source2.com" },
                new MainPanelContextEntity { Id = 63, CircleContextPagesInfoEntityId = 16, Title = "Професійний розвиток та кар'єрне зростання", Context = "Планування та розвиток кар'єри, участь у навчальних програмах, підвищення кваліфікації та просування по службі.", Url = "https://source3.com" },
                new MainPanelContextEntity { Id = 64, CircleContextPagesInfoEntityId = 16, Title = "Законодавчі аспекти працевлаштування", Context = "Знання правових норм щодо працевлаштування, укладення контрактів, трудових відносин, а також захисту прав працівників.", Url = "https://source4.com" }
            );
        }
    }
}
