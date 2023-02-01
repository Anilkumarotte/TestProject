describe('New Window Test', () => {
    it('Should open link in a new window and click back', () => {
        cy.visit('https://alapanme.github.io/testing-cypress.html')
        cy.contains('Try it').click()
        cy.window().then(win => {
            expect(win.name).to.eq('**newWindow**')
            cy.get('#back-button').click()
            cy.window
        }).then(() => {
            cy.url.should('eq', 'https://the-internet.herokuapp.com/')
        })
    })
})
