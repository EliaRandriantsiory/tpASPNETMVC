const btnAjoutTache = document.querySelector("#btnajoutTache")

const btnModal = document.querySelector("#btnModal")
const headerModal = document.querySelector("#exampleModalLabel")
const bodyModal = document.querySelector("#modalBodyTache")
const idTacheModal = document.querySelector("#inputTextIdTache")
const inputTextnomtache = document.querySelector("#inputTextnomtache")
const statusTacheModal = document.getElementById("checkStatusTache1");
const btnModifier = document.querySelectorAll("tr td button")
const btnSupprimer = document.querySelector("#btnSupprimer")

const divStatusTache = document.getElementById("divStatusTache")


const ligneTable = document.getElementsByName("ligneTable")

const currentUser = document.querySelector("#currentUser")


statusTacheModal.onchange = () => {
    statusTacheModal.checked == true ? statusTacheModal.value = "true" : statusTacheModal.value = "false"
    console.log("changed" + statusTacheModal.value)
}


//console.log(btnModifier.length<)
for (let i = 0; i < btnModifier.length; i++) {
    btnModifier[i].onclick = () => {
    modifierOnclick(btnModifier[i])
    }
}
btnAjoutTache.onclick = () => {
    btnModal.value = "Ajouter tâche"
    headerModal.textContent = "Ajouter tâche"
    bodyModal.textContent = "Ajouter tâche"
    inputTextnomtache.value = "rakoto"
    divStatusTache.hidden = true;
}
function modifierOnclick(e) {
    var rowData = e.parentElement.parentElement.children;
    divStatusTache.hidden = false;
    var statustache = rowData[2].querySelector('input[type="checkbox"]').checked
    inputTextnomtache.value = rowData[1].innerHTML.trim()
    //statustache == true ? statusTacheModal.checked = true : statusTacheModal.checked = false
    //statustache == true ? statusTacheModal.value = "true" : statusTacheModal.value = "false"
    if (statustache == true) {
        statusTacheModal.checked = true
        statusTacheModal.value = "true"
    } else {
        statusTacheModal.checked = false
        statusTacheModal.value = "false"
    }
    //statustache == true ? statusTache.checked = true : statusTache.checked = false
    idTacheModal.value = rowData[3].innerHTML

    console.log(inputTextnomtache.value + idTacheModal.value + statustache)
    changeModalAction("Modifier tâche")
}

function changeModalAction(action) {
    btnModal.value = action
    headerModal.textContent = action
    bodyModal.textContent = action
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
