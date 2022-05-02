const candidateRepositoryClass = require('../db/candidatesRepository')
const { validationResult } = require('express-validator')
const urlModule = require('url')

class CandidateController
{
    constructor()
    {
        this.viewListAll = 'candidat/listAll.html'
        this.viewNotFound = 'candidat/notFound.html'
        this.viewShowById = 'candidat/showById.html'
        this.viewAdd = 'candidat/add.html'
        this.viewEdit = 'candidat/edit.html'
        this.viewDelete = 'candidat/delete.html'
        this.candidateRepository = new candidateRepositoryClass()
    }

    async listAll(req, res)
    {
        try {
            let allCandidates = await this.candidateRepository.getAll()
            res.render(
                'candidat/listAll.html',
                {
                    allCandidates,
                    title: "Liste des candidats",
                    flashMessage: req.query.flashMessage
                }
            )
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    }

    async getById(req, res)
    {
        const { id } = req.params

        try {
            let result = await this.candidateRepository.getById(id)

            if (result === undefined) {
                res.status(404)
                res.render(
                    this.viewNotFound,
                    {
                        candidat_id: id,
                    }
                )
            } else {
                res.render(
                    this.viewShowById,
                    {
                        candidate: result
                    }
                )
            }
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    }

    add(req, res)
    {
        res.render(
            this.viewAdd,
            {
                csrfToken: req.session.csrf
            }
        )
    }

    addPost(req, res)
    {
        try {
            const candidate = req.body
            const formErrors = validationResult(req)
            const csrfTokenServer = req.session.csrf
            const csrfTokenClient = req.body.csrfToken

            if (csrfTokenClient != csrfTokenServer) {
                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Formulaire invalide, veuillez réessayer.`
                )
                console.error(`Token form is not valided`)
                res.redirect(url)
            } else if (formErrors.isEmpty()) {
                this.candidateRepository.create(candidate)

                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Le candidat ${candidate.firstname} ${candidate.lastname} a été correctement enregistré.`
                )

                res.redirect(url)
            } else {
                res.render(
                    this.viewAdd,
                    {
                        candidate,
                        errorForm: formErrors.mapped(),
                    }
                )
            }
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    }

    async update(req, res)
    {
        try {
            const { id } = req.params

            let candidate = await this.candidateRepository.getById(id)
            console.log(candidate)

            res.render(
                this.viewEdit,
                {
                    candidate,
                    csrfToken: req.session.csrf
                }
            )
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    }

    async updatePost(req, res)
    {
        try {
            const candidate = req.body
            const { id } = req.params
            const formErrors = validationResult(req)
            const csrfTokenServer = req.session.csrf
            const csrfTokenClient = req.body.csrfToken

            console.log(formErrors.mapped())

            if (csrfTokenClient != csrfTokenServer) {
                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Formulaire invalide, veuillez réessayer.`
                )
                console.error(`Token form is not valided`)
                res.redirect(url)
            } else if (formErrors.isEmpty()) {
                await this.candidateRepository.update(id, candidate)

                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Le candidat référencé ${id} a été correctement modifié.`
                )

                res.redirect(url)
            } else {
                candidate.id = id
                res.render(
                    this.viewEdit,
                    {
                        candidate,
                        errorForm: formErrors.mapped()
                    }
                )
            }
        } catch(err) {
            console.log(err)
            res.status(500).end()
        }
    }

    async remove(req, res)
    {
        try {
            const { id } = req.params

            let candidateToRemove = await this.candidateRepository.getById(id)

            if (!candidateToRemove) {
                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Le candidat référencé ${id} n'existe pas.`
                )
                res.redirect(url)
            } else {
                res.render(
                    this.viewDelete,
                    {
                        candidate: candidateToRemove,
                        csrfToken: req.session.csrf
                    }
                )
            }
        } catch (err) {
            console.log(err)
            res.status(500).end()
        }
    }

    removePost(req, res)
    {
        try {
            const { id } = req.params
            const csrfTokenServer = req.session.csrf
            const csrfTokenClient = req.body.csrfToken

            let candidate = this.candidateRepository.getById(id)

            if (csrfTokenClient != csrfTokenServer) {
                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Formulaire invalide, veuillez réessayer.`
                )
                console.error(`Token form is not valided`)
                res.redirect(url)
            } else if (!candidate) {
                let url = this.generateUrlWithFlashMessage(
                    '/candidates',
                    `Le candidat référencé ${id} n'existe pas.`
                )
                res.redirect(url)
            } else {
                this.candidateRepository.delete(id)
                let url = this.generateUrlWithFlashMessage('/candidates', `Le candidat référencé ${id} a été correctement supprimé.`)
                res.redirect(url)
            }
        } catch(err) {
            console.log(err)
            res.status(500).end()
        }
    }

    generateUrlWithFlashMessage(_url, _flashMessage)
    {
        let url = urlModule.format({
            pathname: _url,
            query: {
                flashMessage: _flashMessage
            }
        })

        return url
    }
}

module.exports = CandidateController
