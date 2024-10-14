//MUDA ENTRE MODO ESCURO E CLARO
document.addEventListener('DOMContentLoaded', function () {
    const toggleButton = document.getElementById("darkModeToggle");
    const lightIcon = document.getElementById("lightIcon");
    const darkIcon = document.getElementById("darkIcon");
    const toggleText = document.getElementById("toggleText");

    // Função para ativar/desativar o modo escuro
    function toggleTheme() {
        if (document.body.classList.contains('dark-mode')) {
            document.body.classList.remove('dark-mode');
            localStorage.setItem('darkMode', 'light');
            lightIcon.style.display = "none";    // Esconde o ícone de sol
            darkIcon.style.display = "inline";   // Exibe o ícone de lua
            toggleText.textContent = "Modo Escuro";
        } else {
            document.body.classList.add('dark-mode');
            localStorage.setItem('darkMode', 'dark');
            lightIcon.style.display = "inline";  // Exibe o ícone de sol
            darkIcon.style.display = "none";     // Esconde o ícone de lua
            toggleText.textContent = "Modo Claro";
        }
    }

    // Verifica o estado atual do modo (do localStorage ou padrão claro)
    const currentMode = localStorage.getItem('darkMode') || 'light';
    if (currentMode === 'dark') {
        document.body.classList.add('dark-mode');
        lightIcon.style.display = "inline";  // Exibe o ícone de sol
        darkIcon.style.display = "none";     // Esconde o ícone de lua
        toggleText.textContent = "Modo Claro";
    } else {
        document.body.classList.remove('dark-mode');
        lightIcon.style.display = "none";    // Esconde o ícone de sol
        darkIcon.style.display = "inline";   // Exibe o ícone de lua
        toggleText.textContent = "Modo Escuro";
    }

    // Adiciona o evento de clique para alternar o tema
    toggleButton.addEventListener("click", toggleTheme);
});


//DATA
document.addEventListener("DOMContentLoaded", function () {
    var dateInput = document.querySelector('input[asp-for="Data"]');

    // Verifique se o campo de data existe
    if (dateInput) {
        // Adiciona automaticamente as barras "/" enquanto o usuário digita
        dateInput.addEventListener("input", function (e) {
            let value = dateInput.value.replace(/\D/g, ''); // Remove caracteres não numéricos
            if (value.length >= 2) {
                value = value.slice(0, 2) + '/' + value.slice(2);
            }
            if (value.length >= 5) {
                value = value.slice(0, 5) + '/' + value.slice(5, 9);  // Limita a data para 10 caracteres
            }
            dateInput.value = value;
        });

        // Formatar data ao carregar a página (de yyyy-MM-dd para dd/MM/yyyy)
        if (dateInput.value.includes("-")) {
            let [year, month, day] = dateInput.value.split("-");
            dateInput.value = `${day}/${month}/${year}`;
        }

        // Alterna para o tipo 'date' ao focar no campo para exibir o calendário
        dateInput.addEventListener("focus", function () {
            dateInput.type = 'date';  // Muda para o tipo 'date' para exibir o calendário
            dateInput.placeholder = 'yyyy-MM-dd';  // Placeholder padrão para o calendário
        });

        // Ao desfocar, volta para o tipo 'text' e formata a data para dd/MM/yyyy
        dateInput.addEventListener("blur", function () {
            if (dateInput.value && dateInput.value.includes("-")) {
                let [year, month, day] = dateInput.value.split("-");
                dateInput.value = `${day}/${month}/${year}`;
            }
            dateInput.type = 'text';  // Volta para 'text' para permitir a formatação
            dateInput.placeholder = 'dd/MM/yyyy';  // Placeholder personalizado para texto
        });

        // Quando a data é alterada pelo calendário, ajusta para dd/MM/yyyy
        dateInput.addEventListener("change", function () {
            if (dateInput.value.includes("-")) {
                let [year, month, day] = dateInput.value.split("-");
                dateInput.value = `${day}/${month}/${year}`;
            }
        });
    }
});

