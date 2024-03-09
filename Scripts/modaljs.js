const btnAjoutTache = document.querySelector("#btnajoutTache")

const btnModal = document.querySelector("#btnModal")
const headerModal = document.querySelector("#exampleModalLabel")
const bodyModal = document.querySelector("#modalBodyTache")
const idTacheModal = document.getElementsByName("inputTextIdTache")

const btnModifier = document.querySelectorAll("button.btnModifier")
const btnSupprimer = document.querySelector("#btnSupprimer")

const ligneTable = document.getElementsByName("ligneTable")

const currentUser = document.querySelector("#currentUser")
idTacheModal.value = "1"
console.log(btnModifier.length)

for (let i = 0; i < btnModifier.length; i++) {
     //Faites quelque chose avec chaque élément
    console.log(btnModifier[i].textContent);
}

console.log(btnModifier.innerHTML)
//console.log(ligneTable.getElementById("idTache"))
ligneTable.onclick = () => {
    console.log(ligneTable.getElementById("idTache"))
}


btnAjoutTache.onclick = () => {
    btnModal.value = "Ajouter tâche"
    headerModal.textContent = "Ajouter tâche"
    bodyModal.textContent = "Ajouter tâche"
}

function modifierOnclick(e) {
    var rowData = e.parentElement.parentElement.children;
    console.log(rowData[1].innerHTML.trim())
    //modalLabel.innerHTML = "Modifier une Tache";
    //idInput.value = rowData[0].innerHTML.trim();
    //tacheInput.value = rowData[1].innerHTML.trim();
    //etatInput.checked = rowData[2].querySelector('input[type="checkbox"]').checked;
    //hiddenInput.className = "form-group utile mt-2";
}

btnModifier.onclick = () => {
    modifierOnclick(btnModifier)
}
//btnModifier.onclick = () => {
//    btnModal.value = "Modifier tâche"
//    headerModal.textContent = "Modifier tâche"
//    bodyModal.textContent = "Modifier tâche"
//    console.log(idTacheModal.value)
    
//}

//btnSupprimer.onclick = () => {
//    btnModal.value = "Supprimer tâche"
//    headerModal.textContent = "Supprimer tâche"
//    bodyModal.textContent = "Supprimer tâche"
//    idTacheModal.value = idTache.value
//}
