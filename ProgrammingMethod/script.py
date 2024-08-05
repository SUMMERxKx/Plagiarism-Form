import sys
import os

def check(file_path, search_term):
    base_name = os.path.basename(file_path).lower()
    Step = None

    # Directly checking for each step in the file name
    if "step1" in base_name:
        Step = "Step1"
    if "step2" in base_name:
        Step = "Step2"
    if "step3" in base_name:
        Step = "Step3"
    if "step4" in base_name:
        Step = "Step4"
    if "step5" in base_name:
        Step = "Step5"

    # Opening the file and checking if the search term exists
    file = open(file_path, 'r')
    content = file.read()
    if search_term.lower() in content.lower():
        print("The term '", search_term, "' was found in ", Step, ".")
        file.close()
        return True
    file.close()
    return False

search_term = sys.argv[-1]
found = False
for file_name in sys.argv[1:-1]:
    if check(file_name, search_term):
        found = True

if not found:
    print("The term '", search_term, "' was not found in any files.")
