function tect(element) {
    let name1 = ["Вибір мови програмування", "Основи синтаксису", "Робота з бібліотеками та фреймворками", "Практика та створення проєктів"];
    let DescriptionAppays1 = ["Перед початком навчання варто визначитися з мовою програмування. Вибір залежить від мети: Python,JavaScript, Java, C#, C++, Swift, Kotlin",
        "Після вибору мови потрібно освоїти її базові конструкції: Змінні та типи даних, Оператори та умови,Цикли та функції",
        "Бібліотеки та фреймворки допомагають пришвидшити розробку: Django, Flask – для бекенду,Spring Boot – для Java-додатків ",
        "Кращий спосіб вивчити програмування – практика: Розв’язуйте задачі на алгоритми,Беріть участь у хакатонах,Розробляйте власні проєкти"];
    let linkAppays1 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name2 = ["Основи баз даних", "Проєктування баз даних", "Робота з реляційними та NoSQL базами", "Оптимізація та безпека баз даних"];
    let DescriptionAppays2 = ["База даних – це організований набір даних, що зберігається та керується системою управління базами даних (СУБД). Основні поняття: Реляційні БД (SQL) – MySQL, PostgreSQL. Нереляційні БД (NoSQL) – MongoDB, Redis, Cassandra та Запити SQL – SELECT, INSERT, UPDATE, DELETE",
        "Щоб створити ефективну БД, потрібно враховувати: Нормалізацію (запобігання дублюванню даних), Зв’язки між таблицями (один-до-одного, один-до-багатьох), Індекси для пришвидшення пошуку даних",
        "Реляційні БД використовують SQL-запити, тоді як NoSQL підходять для гнучкого зберігання даних: MySQL/PostgreSQL – класичні реляційні БД, Redis – ключ-значення для кешування, Firebase – хмарне сховище",
        "Щоб база працювала швидко та безпечно, потрібно: Використовувати індекси для швидкого пошуку, Уникати надмірної вкладеності запитів,Захищати дані від SQL-ін’єкцій"];
    let linkAppays2 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name3 = ["Основи архітектури програмного забезпечення", "Серверні технології та веб-сервери", "Бази даних у серверних застосунках", "Масштабування, балансування навантаження та безпека"];
    let DescriptionAppays3 = ["Архітектура програмного забезпечення визначає структуру та взаємодію компонентів системи. Основні підходи:Монолітна архітектура – вся логіка в одному застосунку",
        "Серверні технології використовуються для обробки запитів та управління даними. Популярні технології: Apache, Nginx – веб-сервери для обробки HTTP-запитів, Django, Flask – Python-фреймворки для бекенду",
        "Сервер обробляє запити до бази даних. Основні підходи:, SQL (MySQL, PostgreSQL) – для структурованих даних, NoSQL (MongoDB, Redis) – для гнучких та швидких запитів,",
        "Щоб система була стійкою, потрібно: Балансування навантаження (Load Balancer, Nginx),Хмарні рішення (AWS, Google Cloud, Azure), Безпека (HTTPS, JWT, OAuth)"];
    let linkAppays3 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name4 = ["Основи DevOps", "Інструменти DevOps", "Хмарні технології", "Моніторинг та безпека"];
    let DescriptionAppays4 = ["DevOps – це методологія, що поєднує розробку (Development) та операційну діяльність (Operations).",
        "Опис Автоматизація – ключовий аспект DevOps. Основні інструменти: Контейнери – Docker, Podman, Jenkins, GitLab CI.",
        "Хмарні платформи надають інструменти для масштабування та керування інфраструктурою: AWS (Amazon Web Services)",
        "Для стабільної роботи системи важливо впровадити моніторинг та безпеку: Моніторинг логів та продуктивності"];
    let linkAppays4 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name5 = ["Практичний досвід та створення проєктів", "Написання резюме та портфоліо", "Підготовка до співбесіди", "Пошук роботи та перші кроки в кар'єрі"];
    let DescriptionAppays5 = ["Для успішного працевлаштування важливо мати реальний досвід роботи з технологіями. Ось як його отримати: Особисті проєкти – створення власних веб-сайтів, додатків або ботів,Open Source – участь у проєктах на GitHub, Фріланс – виконання замовлень на Upwork, Fiverr, Хакатони та конкурси – відмінний спосіб проявити навички.",
        "Щоб зацікавити роботодавця, потрібно грамотно оформити резюме та портфоліо: Резюме – стисло описати навички, досвід, стек технологій, Портфоліо – власні проєкти на GitHub або особистий сайт, LinkedIn – активний профіль для нетворкінгу та пошуку роботи.",
        "Для успішного проходження співбесід потрібно: Алгоритмічні завдання – LeetCode, CodeSignal, Питання щодо структур даних та алгоритмів, Підготовка до технічної співбесіди – mock-інтерв’ю, курси.",
        "Після підготовки варто активно шукати можливості: Джуніор-позиції та стажування – пошук у LinkedIn, на сайтах компаній, Нетворкінг – участь у мітапах, Telegram-чатах для айтішників, Кар'єрний ріст – пробувати нові технології, покращувати софт-скіли"];
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

    maintect(element, "divContent1", headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1);
    maintect(element, "divContent2", headingsArray, name2, DescriptionArray, DescriptionAppays2, linkArray, linkAppays2);
    maintect(element, "divContent3", headingsArray, name3, DescriptionArray, DescriptionAppays3, linkArray, linkAppays3);
    maintect(element, "divContent4", headingsArray, name4, DescriptionArray, DescriptionAppays4, linkArray, linkAppays4);
    maintect(element, "divContent5", headingsArray, name5, DescriptionArray, DescriptionAppays5, linkArray, linkAppays5);
}
function maintect(element, divContent, headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1) {
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