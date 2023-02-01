///  <reference types="cypress"/>

const { Hook } = require("mocha");






describe('Smoke test', () =>
{
    before(function(){

        cy.visit("https://webscrapping-snelstart.azurewebsites.net/");
      })

    beforeEach(function()
    {cy.get('.mat-focus-indicator').click()
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
         it ('validate dropdown'  ,() =>
         {
             
          cy.get('[data-test="product_sort_container"]').select('lohi')


         })

         it ('validate dropdown'  ,() =>
         {
             
          cy.get('[data-test="product_sort_container"]').select('lohi')


         })
         
         it('validate text ', () =>
         {
          cy.get(':nth-child(1) > .inventory_item_description > .inventory_item_label > .inventory_item_desc').find('div').then(function(e){
            //method text to obtain text content
            const t = e.text()
            expect(t).to.contains('carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection,,{matchCase:false}')
          
         }
         )

     afterEach(function()
     {
      
      cy.xpath('//*[@id="react-burger-menu-btn"]').click()
      cy.get('#logout_sidebar_link').click();
      


  
     })

    })
}

)
console.log(Hook)