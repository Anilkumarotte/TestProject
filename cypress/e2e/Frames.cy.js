import 'cypress-iframe'
describe('Tutorialspoint Test', function () {
   // test case
   it('Test Case6', function (){
      // launch URL
      cy.visit("https://jqueryui.com/draggable/");
      // frame loading
      cy.frameLoaded('.demo-frame');
      //shifting focus
      cy.iframe().find("#draggable").then(function(t){
         const frmtxt = t.text()
         //assertion to verify text
         expect(frmtxt).to.contains('Drag me around');
         cy.log(frmtxt);
      })
   });
});