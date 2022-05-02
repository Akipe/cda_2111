const { randomBytes } = require('crypto')

module.exports = (app) => {
    app.use('/', (req, res, next) => {
        if (req.session.csrf === undefined) {
            req.session.csrf = randomBytes(100).toString('base64')
        }

        next()
    })
}