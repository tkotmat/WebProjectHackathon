﻿function HandlerFrondUpdates(element) {
    let name1 = ["HTML та CSS", "JavaScript та DOM", "Основи Backend-розробки", "Контроль версій та розгортання"];
    let DescriptionAppays1 = ["Основи створення веб-сторінок: структура HTML-документів, основні теги та атрибути. Використання CSS для стилізації елементів, верстка сторінок та адаптивний дизайн.",
        "Основи мови програмування JavaScript: змінні, типи даних, функції, цикли та умови. Робота з DOM (Document Object Model), події та маніпуляція HTML-елементами.",
        "Знайомство з серверною частиною веб-розробки. Основи роботи з базами даних (SQL, NoSQL), сервери, API та бекенд-фреймворки, наприклад, ASP.NET MVC.",
        "Використання систем контролю версій, таких як Git. Основи хостингу, деплою веб-додатків, робота з хмарними платформами (Azure, AWS)."];
    let linkAppays1 = ["https://developer.mozilla.org/uk/docs/Learn9", "https://developer.mozilla.org/uk/docs/Web/JavaScript", "https://learn.microsoft.com/uk-ua/aspnet/mvc/", "https://docs.github.com/uk/get-started"];

    let name2 = ["React.js", "Angular", "Vue.js", "ASP.NET Core"];
    let DescriptionAppays2 = ["Популярна бібліотека для створення інтерфейсів користувача. Основи роботи з компонентами, станами (state), пропсами (props) та хуками (hooks). Знайомство з JSX та віртуальним DOM.",
        "Фреймворк від Google для побуд9ви масштабованих SPA (Single Page Applications). Основи TypeScript, робота з компонентами, модулями, сервісами та RxJS.",
        "Простий у засвоєнні фреймворк для створення реактивних інтерфейсів. Робота з шаблонами, директивами, Vue Router та Vuex.",
        "Сучасний бекенд-фреймворк від Microsoft для створення веб-додатків, API та мікросервісів. Вивчення контролерів, middleware, Entity Framework Core та автентифікації."];
    let linkAppays2 = ["https://react.dev/", "https://source3.com", "https://source3.com", "https://learn.microsoft.com/en-us/aspnet/core/"];

    let name3 = ["Chrome DevTools", "Postman", "Webpack", "Docker"];
    let DescriptionAppays3 = ["Набір інструментів для налагодження веб-сторінок у браузері Google Chrome. Дозволяє аналізувати HTML, CSS, JavaScript, мережеві запити, продуктивність та помилки.",
        "Популярний інструмент для тестування API. Дозволяє надсилати HTTP-запити, перевіряти відповіді серверів, створювати колекції запитів та автоматизувати тестування.",
        "Модульний збирач JavaScript-додатків, що оптимізує код, обробляє CSS, зображення та інші ресурси. Вивчення конфігурації, лоадерів та плагінів.",
        "Платформа для контейнеризації, що дозволяє створювати, розгортати та керувати ізольованими середовищами для додатків. Основи Docker Compose, Docker Images та контейнерів."];
    let linkAppays3 = ["https://developer.mozilla.org/uk/docs/Learn9", "https://developer.mozilla.org/uk/docs/Web/JavaScript", "https://learn.microsoft.com/uk-ua/aspnet/mvc/", "https://docs.github.com/uk/get-started"];

    let name6 = ["Фріланс-платформи", "Open Source та волонтерські проєкти", "Стажування та джуніор-вакансії", "Нетворкінг та знайомства"];
    let DescriptionAppays6 = ["Один із найпростіших способів отримати перші комерційні замовлення – почати працювати на фрілансі. Реєструйся на платформах, заповнюй профіль і пропонуй свої послуги.",
        "Допоможи некомерційним організаціям або внеси вклад у Open Source-проєкти. Це не лише корисний досвід, але й можливість створити портфоліо та отримати рекомендації.",
        "Шукай стажування або роботу на позицію Junior Developer. Деякі компанії готові брати початківців без досвіду, якщо є базові навички.",
        "Знайомся з іншими розробниками та шукай можливості через знайомих. Відвідуй IT-конференції, мітапи, вебінари."];
    let linkAppays6 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name4 = ["Основи REST API", "Fetch та Axios", "API з ASP.NET Core", "GraphQL – альтернатива REST"];
    let DescriptionAppays4 = ["Знайомство з принципами REST (Representational State Transfer), методами HTTP-запитів (GET, POST, PUT, DELETE), статус-кодами та форматами обміну даними (JSON, XML).",
        "Робота з API у JavaScript: використання fetch() та бібліотеки Axios для виконання HTTP-запитів, обробка відповідей сервера та помилок.",
        "Розробка API за допомогою ASP.NET Core: створення контролерів, обробка запитів, використання JSON Web Token (JWT) для автентифікації та взаємодія з базами даних через Entity Framework Core.",
        "Після підготовки варто активно шукати можливості: Джуніор-позиції та стажування – пошук у LinkedIn, на сайтах компаній, Нетворкінг – участь у мітапах, Telegram-чатах для айтішників, Кар'єрний ріст – пробувати нові технології, покращувати софт-скіли"];
    let linkAppays4 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name5 = ["Вибір платформи та структури", "Технології для розробки портфоліо", "Додавання проектів", "Оптимізація та SEO"];
    let DescriptionAppays5 = ["Портфоліо можна створити у вигляді окремого веб-сайту або розмістити на платформах типу GitHub Pages, Netlify або Vercel. Важливо продумати структуру: Головна сторінка (про себе, фото, контакти),Проекти (список з описом та посиланнями).",
        "HTML, CSS, JavaScript – для створення статичного сайту, React.js, Vue.js або Angular – для динамічного портфоліо,Bootstrap або Tailwind CSS – для швидкого стилізування.",
        "Важливо додати кілька проєктів, які демонструють навички. Для кожного проекту: Назва та короткий опис, Використані технології, Скріншоти або демо-версія.",
        "Щоб портфоліо виглядало професійно: Використовуй адаптивний дизайн, Додай анімації або інтерактивні елементи, Додай анімації або інтерактивні елементи, Використовуй мета-теги та SEO-практики."];
    let linkAppays5 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let headingsArray = [
        { text: document.getElementById('heading1') },
        { text: document.getElementById('heading2') },
        { text: document.getElementById('heading3') },
        { text: document.getElementById('heading4') }
    ];

    let DescriptionArray = [
        { text: document.getElementById('Description1') },
        { text: document.getElementById('Description2') },
        { text: document.getElementById('Description3') },
        { text: document.getElementById('Description4') }
    ];

    let linkArray = [
        { text: document.getElementById('link1') },
        { text: document.getElementById('link2') },
        { text: document.getElementById('link3') },
        { text: document.getElementById('link4') }
    ];

    maintect1(element, "divContent1", headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1);
    maintect1(element, "divContent2", headingsArray, name2, DescriptionArray, DescriptionAppays2, linkArray, linkAppays2);
    maintect1(element, "divContent3", headingsArray, name3, DescriptionArray, DescriptionAppays3, linkArray, linkAppays3);
    maintect1(element, "divContent4", headingsArray, name4, DescriptionArray, DescriptionAppays4, linkArray, linkAppays4);
    maintect1(element, "divContent5", headingsArray, name5, DescriptionArray, DescriptionAppays5, linkArray, linkAppays5);
    maintect1(element, "divContent6", headingsArray, name6, DescriptionArray, DescriptionAppays6, linkArray, linkAppays6);
}
function maintect1(element, divContent, headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1) {
    console.log(divContent);
    if (element.id === divContent) {
        for (let i = 0; i < headingsArray.length; i++) {
            headingsArray[i].text.innerText = name1[i];
        }

        for (let i = 0; i < DescriptionArray.length; i++) {
            DescriptionArray[i].text.innerText = DescriptionAppays1[i];
        }

        for (let i = 0; i < linkArray.length; i++) {
            linkArray[i].text.href = linkAppays1[i];
        }
    }
}