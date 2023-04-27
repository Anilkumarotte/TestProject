///  <reference types="cypress"/>






describe('Smoke test', () =>
{
    before(function(){

        cy.visit("https://webscrapping-snelstart.azurewebsites.net/");
      })

      it("Validate login with valid creds", function () {
        cy.get('.mat-button-wrapper').click();
       cy.window().then((win) => {
        cy.stub(win, 'open', url => {
            win.location.href = 'https://login.microsoftonline.com/c8379813-1a03-43cb-84b7-4c6877883082/oauth2/v2.0/authorize?client_id=2fcd55b1-1f4f-4c3e-b985-c96e95bd8d07&scope=user.read%20openid%20profile%20offline_access&redirect_uri=https%3A%2F%2Fwebscrapping-snelstart.azurewebsites.net&client-request-id=06ebaba3-cd5e-4790-95b5-984f143abeeb&response_mode=fragment&response_type=code&x-client-SKU=msal.js.browser&x-client-VER=2.20.0&x-client-OS=&x-client-CPU=&client_info=1&code_challenge=R_-4KC2R-W-kjGvEQPeDJ2RjrGqog9q_RgRw97pyjb4&code_challenge_method=S256&nonce=9de66b37-d2da-427e-a811-4358cdf22193&state=eyJpZCI6IjAwODc5MzVlLTBjYjAtNGU1OS1hMjFlLWIzNTRkYzE1NDcwZCIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicG9wdXAifX0%3D&sso_reload=true';
          }).as("prompt").returns('********.com');
         // cy.window().then(function($wind){
           // cy.stub($wind, 'prompt').returns('Hello')
            
        })
        
       // cy.get('button').click({force:true})


    })

})
//popup
