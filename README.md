## Directory to CSV
Program containing recursive function which turns directories and file information into .csv file.
# Details
kek(string path) function gets information about directory catalogs and files. Writes into text variable current directory name, then loops through all files
in that directory (if there are any). I file is found then it is saved in given format to earlier said text variable: new line - delimiter - name of file - 
date of creation of file - extension - total size in bytes. After loop new line is added, text is appended into file and another loop is called for each catalog in 
directory containing kek function with new subdirectory.
