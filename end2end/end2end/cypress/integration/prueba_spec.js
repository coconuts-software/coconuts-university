describe('Mi primer test', function () {
    it('No hace demasiado', function () {
        expect(true).to.equal(true)
    })

    it('Visita una pagina', function () {
        cy.visit('https://example.cypress.io')
    })

    it('Buscar el texto "type"', function () {
        cy.visit('https://example.cypress.io')

        cy.contains('type')
    })

    it('click en el link "type"', function () {
        cy.visit('https://example.cypress.io')

        cy.contains('type').click()
    })

    it('clickear "type" navega a una nueva url', () => {
        cy.visit('https://example.cypress.io')

        cy.contains('type').click()

        cy.url().should('include', '/commands/actions')
    })

    it('Escribir en un input', () => {
        cy.visit('https://example.cypress.io')

        cy.contains('type').click()

        cy.url().should('include', '/commands/actions')

        cy.get('.action-email')
        .type('fake@email.com')
        .should('have.value', 'fake@email.com')
    })

    it('clicking "type" shows the right headings', function () {
        cy.visit('https://example.cypress.io')

        cy.pause()

        cy.contains('type').click()

        cy.url().should('include', '/commands/actions')

        cy.get('.action-email')
            .type('fake@email.com')
            .should('have.value', 'fake@email.com')
    })
})