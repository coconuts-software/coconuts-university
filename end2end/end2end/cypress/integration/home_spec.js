describe('Test home page', function () {
    it('chequear contenido "welcome"', function () {
        cy.visit('https://localhost:5001')

        cy.contains('Welcome')
    })

    it('click en "Privacy" navega a una nueva URL', () => {
        cy.visit('https://localhost:5001')

        cy.contains('Privacy').click()

        // Deberia ser una nueva URL que incluya '/Home/Privacy'

        cy.url().should('include', '/Home/Privacy')
    })
})