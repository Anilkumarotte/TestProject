///  <reference types="cypress"/>






describe('Smoke test', () =>
{
    before(function(){

        cy.visit("https://www.saucedemo.com/");
      })

    beforeEach(function()
    {
      cy.get('[data-test="username"]').type('standard_user')
      cy.get('[data-test="password"]').type('secret_sauce')
      cy.get('[data-test="login-button"]').click();

    })

    it('validate product',() =>  
    {
      cy.get('#item_4_title_link > .inventory_item_name').click();



    }
    )
    it ('validate add to cart ', () =>
    {
     
      cy.get('[data-test="add-to-cart-sauce-labs-backpack"]').click()


    }
    )



     afterEach(function()
     {
      
      cy.xpath('//*[@id="react-burger-menu-btn"]').click()
      cy.get('#logout_sidebar_link').click();
      


   

     })
}

)