describe('Example to demonstrate the handling of new browser windows in cypress', () => {

    it('Handling new Browser Tab', function () {
        cy.visit('https://the-internet.herokuapp.com/windows')
        cy.get('.example > a').invoke('removeAttr', 'target').click()
        cy.url()
            .should('include', '/windows/new')
        cy.get('h3')
            .should('have.text', 'New Window')
    })
 
    it('Handling new Browser Window', function () {
        cy.visit('https://alapanme.github.io/testing-cypress.html')
        cy.get('button').click()
       cy.go('back')
 
 
       })
        
          })
 