function generateUserTable(json)
{
    for (let user of json) {
        let tr = document.createElement('tr');
        let td = document.createElement('td');
        td.textContent = user.user_name;

        tr.appendChild(td);

        document.getElementById('userTable').appendChild(tr);
    }
}

// Pour le fetch, on peut définir un accés local ou distant
fetch("https://api.devoldere.net/dataset/users.json")
// Le role du prochain then sera de formater la requete, en JSON, binaire, etc
.then(response => {
    console.log(response);
    return response.json();
})
// On récupére le JSON dans le paramètre "json"
.then(json => {
    console.log(json);
    generateUserTable(json);
})
// On affiche l'erreur en cas d'échec
.catch(error => {
    console.error(error);
})