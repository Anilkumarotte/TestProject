
import 'cypress-iframe'

describe( 'google', () =>
{

it ('Auto Complete Drop down', ()=>
{
    cy.visit('https://www.google.com/')


    cy.iframe().find('rr4y5c').click()

})

})