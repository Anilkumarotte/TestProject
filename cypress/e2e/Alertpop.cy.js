describe('pop alerts practice', function(){

it('windows pop up', function(){

    cy.visit('https://qaboxletstestcypresspracticesite.netlify.app/differentalerttypes.html');
})

  it('windows pop', function()
  {
    const newurl ="https://www.youtube.com/c/qaboxletstest/"
    ;
 
 cy.window().then(win=>{  
    const  stub =cy.stub(win,'open').as('windowopen');

 })


    cy.get('button#winpop').click()
    cy.get('@windowopen',{timeout:6000})
    .should('be.calledWith',newurl);
    cy.window().then(win=>{  
      win.Location.href = newurl 
   cy.xpath('(//input[@id="search"])').type('cypress by qa lets test{enter}',{timeout:6000});
   })   
   
    
    })
})

