exports.error404 = (req, res) => {
    res.status(404).send("Erreur 404: page non trouvé")
}
