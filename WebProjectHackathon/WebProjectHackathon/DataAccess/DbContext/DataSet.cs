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
    }
}
