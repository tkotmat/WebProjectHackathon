let greenCount = 0;
let lastOpenedButton = null;

function toggleSidebar(element) {
    const sidebar = document.querySelector('.sidebar');
    sidebar.classList.toggle('open');
    HandlerBackUpdates(element);
}

function toggleSelect(element) {
    lastOpenedButton = element;
}

window.onload = function () {
    const buttonBelow = document.getElementById("buttonBelow");
    const submitButton = document.getElementById("buttonSumbit");
    buttonBelow.addEventListener("click", buttonBelowLogic);
    submitButton.addEventListener("click", submitButtonLogic);
}

function buttonBelowLogic() {
    if (lastOpenedButton) {
        const activeStep = lastOpenedButton;

        if (activeStep.classList.contains("green")) {
            activeStep.classList.remove("green");
            activeStep.style.backgroundColor = "";
            greenCount--;
        } else {
            activeStep.classList.add("green");
            activeStep.style.backgroundColor = "#778D45";
            greenCount++;
        }
    }
}

function submitButtonLogic() {
    if (greenCount >= 3) {
        alert("Вітаємо! Ви пройшли важливі кроки на шляху до професії!");
    } else {
        alert("Виберіть хоча б 3 кроки, щоб продовжити.");
    }
}

function HandlerBackUpdates(element) {
    const headingsArray = [
        document.getElementById('heading1'),
        document.getElementById('heading2'),
        document.getElementById('heading3'),
        document.getElementById('heading4')
    ];

    const DescriptionArray = [
        document.getElementById('Description1'),
        document.getElementById('Description2'),
        document.getElementById('Description3'),
        document.getElementById('Description4')
    ];

    const linkArray = [
        document.getElementById('link1'),
        document.getElementById('link2'),
        document.getElementById('link3'),
        document.getElementById('link4')
    ];

    const divIndex = parseInt(element.id.replace("divContent", "")) - 1;
    const panels = circlePanels[divIndex].panels;

    for (let i = 0; i < panels.length; i++) {
        headingsArray[i].innerText = panels[i].Title;
        DescriptionArray[i].innerText = panels[i].Content;
        linkArray[i].href = panels[i].ImageUrl;
    }
}
