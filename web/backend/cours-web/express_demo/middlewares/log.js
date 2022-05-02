module.exports = (app) => {
    app.use((req, res, next) => {
        const method = req.method
        const path = req.originalUrl

        console.log(`${method} ${path}`)

        next()
    })
}
