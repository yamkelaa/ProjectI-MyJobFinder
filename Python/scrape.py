import selenium.webdriver as webdriver
from selenium.webdriver.chrome.service import Service
import time
def scrape_website(website):
    print("Launching Chrome Browser")

#This application allows us to control chrome, we need to specify where this is
    chrome_driver_path = "./chromedriver.exe"
    #Specifies how the driver should operate, do we want to run it in headless mode? Perhaps ignore images
    options = webdriver.ChromeOptions()
    #This will be where the Chrome browser application lives
    driver = webdriver.Chrome(service=Service(chrome_driver_path), options=options)

    try:
        driver.get(website)
        print("Page Loaded..")
        html = driver.page_source
        time.sleep(10)

        return html
    finally:
        driver.quit()
