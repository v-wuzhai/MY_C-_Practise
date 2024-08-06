import random
from faker import Faker
import sys

faker = Faker()

def generateCSV(num, subject):
    with open(f"student_{num}_{subject}.csv", 'w') as file:
        for j in range(0, num):
            name = faker.name()
            file.write(f"{name},")

            for i in range(0, subject):
                score = random.uniform(0, 100)
                if (score < 20):
                    score += 20
                score = round(score, 2)
                file.write(f"{score}")
                if i + 1 != subject:
                    file.write(",")
                else:
                    file.write("\n")
        file.close()
        

def main():
    argv = sys.argv
    num = 10
    subject = 2

    if len(argv) >= 2:
        num = int(argv[1])
    if len(argv) >= 3:
        subject = int(argv[2])
    if subject >= 2 and num > 0:
        generateCSV(num, subject)
    else:
        print("Error ! Number of students must be >= 0")
        print("Error ! Number of subject must be >= 2")
        print("Usage: python csv_generator.py <num_of_student> <num_of_subject>")
        print("Output file : student_<num_of_student>_<num_of_subject>.csv")


if __name__ == "__main__":
    main()