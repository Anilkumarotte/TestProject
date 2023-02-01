/// <reference types="Cypress" />

import LoginPage from "./POM/loginpage.cy"

import Logoutpage from "./POM/Logoutpage.cy"    


describe('Test Suite', function()
{
it.only('Valid login test', function(){

const lp = new LoginPage()
lp.visit()
lp.EnterEmail('admin@yourstore.com')
lp.Enterpassword('admin')
lp.Submitbutton()


})


it('validate logout button ', function()
{
    const lg = new Logoutpage()
    lg.logoutbutton()

})
}
   

)