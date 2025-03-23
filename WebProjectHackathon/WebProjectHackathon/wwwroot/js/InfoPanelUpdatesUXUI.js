function tect4(element) {
    let name1 = ["Візуальна ієрархія", "Типографіка в UI/UX", "Колір та контраст", "Сітки та вирівнювання"];
    let DescriptionAppays1 = ["Організація елементів інтерфейсу за рівнем важливості, використовуючи розмір, колір, контраст і простір.",
        "Вибір шрифтів, їх поєднання, розмір та інтервали для зручності читання і візуальної гармонії.",
        "Використання кольорової палітри для передачі настрою, підвищення зручності використання та створення акцентів. ",
        "Використання сіткових систем для впорядкування контенту та забезпечення гармонійного розташування елементів."];
    let linkAppays1 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name2 = ["Аналіз цільової аудиторії", "Юзабіліті-тестування", "Створення персон користувачів", "Картування користувацького шляху (User Journey)"];
    let DescriptionAppays2 = ["Визначення потреб, поведінки та очікувань користувачів за допомогою опитувань, інтерв’ю та аналізу даних.",
        "Перевірка зручності використання продукту через спостереження за реальними користувачами та виявлення проблем у взаємодії.",
        "Розробка узагальнених портретів користувачів для кращого розуміння їхніх цілей, мотивації та болей.",
        "Візуалізація взаємодії користувача з продуктом, виявлення проблемних точок і можливостей для покращення UX."];
    let linkAppays2 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name3 = ["Figma", "Adobe XD", "Sketch", "Miro"];
    let DescriptionAppays3 = ["Популярний інструмент для створення макетів, прототипування та спільної роботи над дизайном.",
        "Програма для проєктування інтерфейсів, створення інтерактивних прототипів і тестування UX-рішень.",
        "Інструмент для розробки UI-дизайну, що використовується переважно на macOS, із широкими можливостями плагінів.",
        "Онлайн-дошка для командної роботи, мозкового штурму, створення схем користувацького шляху та UX-досліджень."];
    let linkAppays3 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name4 = ["Основи HTML та CSS", "CSS-анімації та переходи", "Основи JavaScript для UI", "Фреймворки та бібліотеки (Bootstrap, Tailwind CSS)"];
    let DescriptionAppays4 = ["Вивчення базової структури веб-сторінок, стилізація елементів та створення адаптивного дизайну.",
        "Додавання динаміки до інтерфейсу за допомогою анімацій, плавних переходів і ефектів наведення.",
        "Використання JavaScript для інтерактивності, таких як модальні вікна, випадаючі меню та динамічний контент.",
        "Використання готових компонентів і стилів для прискорення розробки та уніфікації дизайну."];
    let linkAppays4 = ["https://source1.com", "https://source2.com", "https://source3.com", "https://source4.com"];

    let name5 = ["Демонстрація проєктів", "Опис процесу роботи", "Інтерактивні прототипи", "Відгуки та рекомендації"];
    let DescriptionAppays5 = ["Включення кількох ваших найкращих проєктів, які демонструють ваші навички в дизайні, дослідженнях та прототипуванні.",
        "Документування етапів роботи над проєктами, від досліджень до реалізації, щоб показати ваше розуміння процесу UX/UI-дизайну.",
        "Додавання інтерактивних прототипів, щоб потенційні клієнти могли взаємодіяти з вашим дизайном і бачити його в дії.",
        "Додавання відгуків клієнтів або колег, які можуть підтвердити вашу професійну кваліфікацію та досвід."];
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

    maintect4(element, "divContent1", headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1);
    maintect4(element, "divContent2", headingsArray, name2, DescriptionArray, DescriptionAppays2, linkArray, linkAppays2);
    maintect4(element, "divContent3", headingsArray, name3, DescriptionArray, DescriptionAppays3, linkArray, linkAppays3);
    maintect4(element, "divContent4", headingsArray, name4, DescriptionArray, DescriptionAppays4, linkArray, linkAppays4);
    maintect4(element, "divContent5", headingsArray, name5, DescriptionArray, DescriptionAppays5, linkArray, linkAppays5);
}
function maintect4(element, divContent, headingsArray, name1, DescriptionArray, DescriptionAppays1, linkArray, linkAppays1) {
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