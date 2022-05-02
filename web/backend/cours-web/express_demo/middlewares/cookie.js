const cookieParser = require('cookie-parser')
const cookieSession = require('cookie-session')

module.exports = (app) => {
    app.use(cookieParser())
    app.use(cookieSession({
        name: 'session',
        secret: 'A_SECRETE_TO_GENERATE',
        maxAge: 1000 * 60 * 60 * 24,
        sameSite: 'lax',
        path: '/',
        secure: process.env.NODE_ENV === 'production',
        httpOnly: true
    }))
}