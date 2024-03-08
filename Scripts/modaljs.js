const btnAjoutTache = document.querySelector("#btnajoutTache")

const btnModal = document.querySelector("#btnModal")
const headerModal = document.querySelector("#exampleModalLabel")
const bodyModal = document.querySelector("#modalBodyTache")
const idTacheModal = document.getElementsByName("inputTextIdTache")

const btnModifier = document.querySelector("#btnModifier")
const btnSupprimer = document.querySelector("#btnSupprimer")

const idTache = document.querySelector("#idTache")

const currentUser = document.querySelector("#currentUser")
idTacheModal.value = "1"

btnAjoutTache.onclick = () => {
    btnModal.value = "Ajouter tâche"
    headerModal.textContent = "Ajouter tâche"
    bodyModal.textContent = "Ajouter tâche"
}
function modifierOnclick(e) {
    var rowData = e.parentElement.parentElement.children;
    modalLabel.innerHTML = "Modifier une Tache";
    idInput.value = rowData[0].innerHTML.trim();
    tacheInput.value = rowData[1].innerHTML.trim();
    etatInput.checked = rowData[2].querySelector('input[type="checkbox"]').checked;
    hiddenInput.className = "form-group utile mt-2";
}
//btnModifier.onclick = () => {
//    btnModal.value = "Modifier tâche"
//    headerModal.textContent = "Modifier tâche"
//    bodyModal.textContent = "Modifier tâche"
//    console.log(idTacheModal.value)
    
//}
btnSupprimer.onclick = () => {
    btnModal.value = "Supprimer tâche"
    headerModal.textContent = "Supprimer tâche"
    bodyModal.textContent = "Supprimer tâche"
    idTacheModal.value = idTache.value
}
