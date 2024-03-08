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
btnModifier.onclick = () => {
    btnModal.value = "Modifier tâche"
    headerModal.textContent = "Modifier tâche"
    bodyModal.textContent = "Modifier tâche"
    console.log(idTacheModal.value)
    
}
btnSupprimer.onclick = () => {
    btnModal.value = "Supprimer tâche"
    headerModal.textContent = "Supprimer tâche"
    bodyModal.textContent = "Supprimer tâche"
    idTacheModal.value = idTache.value
}
