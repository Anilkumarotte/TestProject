{
    "title": "Recording 1/27/2023 at 5:39:37 PM",
    "steps": [
        {
            "type": "setViewport",
            "width": 1528,
            "height": 266,
            "deviceScaleFactor": 1,
            "isMobile": false,
            "hasTouch": false,
            "isLandscape": false
        },
        {
            "type": "navigate",
            "url": "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login",
            "assertedEvents": [
                {
                    "type": "navigation",
                    "url": "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login",
                    "title": "OrangeHRM"
                }
            ]
        },
        {
            "type": "click",
            "target": "main",
            "selectors": [
                [
                    "aria/Username"
                ],
                [
                    "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(2) > div > div:nth-child(2) > input"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input"
                ]
            ],
            "offsetY": 23.662506103515625,
            "offsetX": 92.29998779296875
        },
        {
            "type": "change",
            "value": "Admin",
            "selectors": [
                [
                    "aria/Username"
                ],
                [
                    "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(2) > div > div:nth-child(2) > input"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input"
                ]
            ],
            "target": "main"
        },
        {
            "type": "click",
            "target": "main",
            "selectors": [
                [
                    "aria/Password"
                ],
                [
                    "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(3) > div > div:nth-child(2) > input"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input"
                ]
            ],
            "offsetY": 26.462493896484375,
            "offsetX": 67.29998779296875
        },
        {
            "type": "change",
            "value": "admin123",
            "selectors": [
                [
                    "aria/Password"
                ],
                [
                    "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(3) > div > div:nth-child(2) > input"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input"
                ]
            ],
            "target": "main"
        },
        {
            "type": "click",
            "target": "main",
            "selectors": [
                [
                    "aria/Login[role=\"button\"]"
                ],
                [
                    "#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"
                ]
            ],
            "offsetY": 10.462493896484375,
            "offsetX": 185.29998779296875,
            "assertedEvents": [
                {
                    "type": "navigation",
                    "url": "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index",
                    "title": ""
                }
            ]
        },
        {
            "type": "click",
            "target": "main",
            "selectors": [
                [
                    "aria/Dashboard[role=\"link\"]"
                ],
                [
                    "#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(8) > a"
                ],
                [
                    "xpath///*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[8]/a"
                ]
            ],
            "offsetY": 12.399993896484375,
            "offsetX": 164,
            "assertedEvents": [
                {
                    "type": "navigation",
                    "url": "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index",
                    "title": ""
                }
            ]
        }
    ]
}