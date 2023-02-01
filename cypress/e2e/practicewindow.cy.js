describe('Smoke test', () =>
{
    before(function(){

        cy.visit("https://bistromd-staging.myshopify.com/");
      })

      it("Validate login with valid creds", function () {
        cy.get('#password').type('notyet')
        cy.get('.btn').click().
        then(() =>
        {
         cy.wrap(window.top.document.querySelector('[aria-label="Close Modal"]', {timeout: 60000})).click({force:true});
        // cy.wrap(  window.top.document.querySelector('["placeholder="Email Address"]', {timeout: 60000})).type("qfsdh")
        })


    })

})