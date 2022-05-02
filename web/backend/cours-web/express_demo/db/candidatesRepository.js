// On importe les données de la BDD
const baseRepository = require('./baseRepository')
const Candidate = require('./Candidate')

class CandidateRepository
{
    async getAll()
    {
        let allCandidatesSql = await baseRepository.getAll(
            "SELECT id, lastname, firstname, slogan FROM candidates"
        )
        
        let allCandidates = []
        allCandidatesSql.forEach(candidatJson => {
            allCandidates.push(this.generateCandidateFromJson(candidatJson))
        });

        return allCandidates
    }
    
    async getById(id)
    {
        let candidateJson = await baseRepository.getOne(
            "SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?",
            [id]
        )
    
        if (candidateJson != null) {
            return this.generateCandidateFromJson(candidateJson)
        } else {
            return false
        }
    }
    
    async create(_candidate)
    {
        let jsonCandidate = this.getJsonFromCandidate(_candidate)

        return await baseRepository.execute(
            `INSERT INTO candidates (lastname, firstname, slogan) VALUES (?, ?, ?)`,
            [jsonCandidate.lastname, jsonCandidate.firstname, jsonCandidate.slogan]
        )
    }
    
    async update(id, _candidate)
    {
        let jsonCandidate = this.getJsonFromCandidate(_candidate)

        return await baseRepository.execute(
            `UPDATE candidates SET lastname=?, firstname=?, slogan=? WHERE id=?`,
            [jsonCandidate.lastname, jsonCandidate.firstname, jsonCandidate.slogan, id]
        )
    }
    
    async delete(id)
    {
        return await baseRepository.execute(
            'DELETE FROM candidates WHERE id=?',
            [id]
        )
    }
    
    generateCandidateFromJson(_jsonCandidate)
    {
        return new Candidate(
            _jsonCandidate.id,
            _jsonCandidate.firstname,
            _jsonCandidate.lastname,
            _jsonCandidate.slogan
        )
    }

    getJsonFromCandidate(_candidate)
    {
        let json = {
            id: _candidate.id,
            firstname: _candidate.firstname,
            lastname: _candidate.lastname,
            slogan: _candidate.slogan
        }
        
        return json
    }
}

module.exports = CandidateRepository
