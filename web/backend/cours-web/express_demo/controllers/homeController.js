exports.index = (req, res) => {
    res.send("Accueil du controlleur")
}

exports.about = (req, res) => {
    res.send('A propos')
}

exports.helloName = (req, res) => {
    let name = req.params.name // On récupére le marqueur "name" de la route
    res.send(`Hello ${name} !`)
}
