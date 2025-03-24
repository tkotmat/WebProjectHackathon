function tect2(element) {
    let name1 = ["HR-менеджер", "Освоєння HR-інструментів", "Розвиток комунікаційних навичок", "Знання трудового законодавства"];
    let DescriptionAppays1 = ["Основи управління персоналом, психологія роботи з людьми та підбір кадрів: Основи менеджменту: як знайти, мотивувати та утримати співробітників.",
        "Знайомство з платформами для пошуку кандидатів та автоматизація рекрутингу: LinkedIn, Work.ua, Djinni: пошук та аналіз профілів,ATS-системи (Workable, Greenhouse, BambooHR): автоматизація процесу найму.",
        "Навички проведення співбесід та вирішення конфліктів у командах: •	Підготовка ефективних питань та оцінка відповідей кандидатів, Визначення мотивації та рівня професіоналізму претендента.",
        "Оформлення документації та правові аспекти працевлаштування: Контракти, політики компанії, NDA, Законодавчі вимоги щодо працевлаштування та оформлення співробітників."];
    let linkAppays1 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name2 = ["Основи HR-аналізу", "Підбір та найм персоналу", "Аналіз залученості співробітників", "HR-автоматизація та ІТ-інструменти"];
    let DescriptionAppays2 = ["Вивчення методів збору та аналізу даних про співробітників для оцінки їхньої ефективності та побудови метрик продуктивності.",
        "Використання інструментів для автоматизації процесів підбору кандидатів, таких як HR-боти та онлайн-платформи для співбесід та тестування.",
        "Застосування інструментів для вимірювання рівня залученості та визначення факторів, що впливають на мотивацію та утримання співробітників.",
        "Освоєння програмних рішень для автоматизації HR-процесів, включаючи розрахунок заробітної плати, управління відпустками та лікарняними."];
    let linkAppays2 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name3 = ["Основи ефективної комунікації", "Управління конфліктами", "Командна комунікація", "Міжособистісні комунікації"];
    let DescriptionAppays3 = ["Вивчення принципів та технік ефективного спілкування, зокрема активного слухання та чіткої передачі інформації.",
        "Розвиток навичок розв'язання конфліктних ситуацій у команді, використання технік для конструктивного вирішення суперечок.",
        "Опанування стратегій для ефективної роботи в команді, в тому числі обговорення ідей, обміну інформацією та підтримки колег.",
        "Розвиток навичок взаємодії з різними людьми, включаючи встановлення контактів, створення довірливих відносин і адаптацію до різних стилів спілкування."];
    let linkAppays3 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name4 = ["Основи трудового законодавства", "Оформлення трудових відносин", "Права та обов'язки працівників і роботодавців", "Урегулювання трудових суперечок"];
    let DescriptionAppays4 = ["Вивчення основних положень трудового кодексу та законів, що регулюють права та обов'язки роботодавців і працівників.",
        "Опанування процесами укладання трудових договорів, реєстрації працівників, а також розуміння різних видів трудових контрактів.",
        "Знання прав та обов'язків сторін трудових відносин, включаючи питання оплати праці, відпусток, лікарняних та дисциплінарних санкцій.",
        "Ознайомлення з процедурами вирішення трудових спорів, звернення до органів праці та судових установ, а також медіація в трудових питаннях."];
    let linkAppays4 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name5 = ["Пошук та підбір роботи", "Процес адаптації на новому місці роботи", "Професійний розвиток та кар'єрне зростання", "Законодавчі аспекти працевлаштування"];
    let DescriptionAppays5 = ["Опанування методів ефективного пошуку роботи, створення резюме та супровідного листа, а також підготовка до співбесід.",
        "Вивчення кроків для успішної адаптації на новій посаді, знайомство з корпоративною культурою та вимогами компанії.",
        "Планування та розвиток кар'єри, участь у навчальних програмах, підвищення кваліфікації та просування по службі.",
        "Знання правових норм щодо працевлаштування, укладення контрактів, трудових відносин, а також захисту прав працівників."];
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
    console.log(";ffew");
    maintect3(element, "divContent1", headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1);
    maintect3(element, "divContent2", headingsArray, name2, DescriptionArray, DescriptionAppays2, linkArray, linkAppays2);
    maintect3(element, "divContent3", headingsArray, name3, DescriptionArray, DescriptionAppays3, linkArray, linkAppays3);
    maintect3(element, "divContent4", headingsArray, name4, DescriptionArray, DescriptionAppays4, linkArray, linkAppays4);
    maintect3(element, "divContent5", headingsArray, name5, DescriptionArray, DescriptionAppays5, linkArray, linkAppays5);
}

function maintect3(element, divContent, headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1) {
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