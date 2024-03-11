const btnAjoutTache = document.querySelector("#btnajoutTache")

const btnModal = document.querySelector("#btnModal")
const headerModal = document.querySelector("#exampleModalLabel")
const bodyModal = document.querySelector("#modalBodyTache")
const idTacheModal = document.querySelector("#inputTextIdTache")
const inputTextnomtache = document.querySelector("#inputTextnomtache")
const statusTacheModal = document.getElementById("checkStatusTache1");
const btnActionPost = document.querySelectorAll("tr td button")
const btnModifier = document.querySelectorAll("tr td button.btnModifier")
const btnSupprimer = document.querySelectorAll("tr td button.btnSupprimer")

const labelSuppr = document.querySelector("#confSuppr")

const divStatusTache = document.getElementById("divStatusTache")

const ajoutModifier = document.querySelector("#AjoutModifier")
const supprTache = document.querySelector("#SupprTache")
const labelStatusTache = document.querySelector('#labelStatusTache')

const ligneTable = document.getElementsByName("ligneTable")

const currentUser = document.querySelector("#currentUser")

//statestatusTacheModal()
function statestatusTacheModal() {
    if (statusTacheModal.checked == true) {
        statusTacheModal.value = "true"
        labelStatusTache.innerHTML = "Terminé"
    } else {
        statusTacheModal.value = "false"
        labelStatusTache.innerHTML = "Non Terminé"
    }
}

statusTacheModal.onchange = () => {
    //statusTacheModal.checked == true ? statusTacheModal.value = "true" : statusTacheModal.value = "false"
    //console.log("changed" + statusTacheModal.value)
    statestatusTacheModal()
}

for (let i = 0; i < btnModifier.length; i++) {
    btnModifier[i].onclick = () => {
    modifierOnclick(btnModifier[i])
    }
}

for (let i = 0; i < btnSupprimer.length; i++) {
    btnSupprimer[i].onclick = () => {
        supprimerOnclick(btnSupprimer[i])
    }
}

btnAjoutTache.onclick = () => {
    btnModal.value = "Ajouter tâche"
    headerModal.textContent = "Ajouter tâche"
    bodyModal.textContent = "Ajouter tâche"
    //inputTextnomtache.value = "rakoto"
    divStatusTache.hidden = true;
    ajoutModifier.hidden = false
    supprTache.hidden = true
}

function supprimerOnclick(e) {
    var rowData = e.parentElement.parentElement.children;
    ajoutModifier.hidden = true
    supprTache.hidden = false
    labelSuppr.innerHTML = rowData[0].innerHTML.trim()
    idTacheModal.value = rowData[2].innerHTML
    changeModalAction("Supprimer tâche")
}
function modifierOnclick(e) {
    var rowData = e.parentElement.parentElement.children;
    divStatusTache.hidden = false;
    ajoutModifier.hidden = false
    supprTache.hidden = true
    var statustache = rowData[1].querySelector('input[type="checkbox"]').checked
    inputTextnomtache.value = rowData[0].innerHTML.trim()
    statestatusTacheModal()
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
    idTacheModal.value = rowData[2].innerHTML

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
