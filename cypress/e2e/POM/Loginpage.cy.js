class LoginPage
{
    visit()
    {
        cy.visit("https://admin-demo.nopcommerce.com/login")
    }


    EnterEmail(value)
    {
         const email =cy.get('[id=Email]')
         email.clear()
         email.type(value)
         return this
 
    }
    
    Enterpassword(value)
    {
         const pwd =cy.get('[id=Password]')
         pwd.clear()
         pwd .type(value)
         return this    
    }

              Submitbutton()
    {
         const button =cy.get('[type=submit]')
         button.click()
     
        // return this
 
  
    }

}
export default LoginPage