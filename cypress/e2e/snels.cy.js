

describe('Smoke test', () =>
{
    before(function(){

        cy.visit("https://***********.com/");
      })

      it("Validate login with valid creds", function () {
        cy.get('.mat-button-wrapper').click()
        cy.window().then(function($wind){
          cy.stub($wind, 'prompt',{timeout:6000}).returns('*******@gmail.com')
      // .then(() =>
      cy.get('[value="Next"]').click({force:true});
       // cy.wrap(window.top.document.querySelector('[class="form-group col-md-24"]',{timeout: 60000})).type("okumar@ariqt.com");

           
       })


    })

})
    









