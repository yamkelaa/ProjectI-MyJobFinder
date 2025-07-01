from selenium import webdriver
from selenium.webdriver.chrome.service import Service
import time 

driver = webdriver.Chrome()


driver.get("https://www.pnet.co.za/en/")
time.sleep(10)

#log into the site
#accept any privacy/policy agreements
#search for job vacancies
#click on each job vacancy and get the data
#collect all the data and add it to the datasheet
#repeat for all given websites
#format that datasheet into an email message 
#send that datasheet to the main C# application









driver.quit()


