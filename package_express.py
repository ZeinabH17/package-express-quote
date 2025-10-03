# Shipping Quote Calculator for Package Express

# First message displayed to the user
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt the user for the package weight
weight = float(input("Please enter the package weight: "))

# If the weight is over 50, display an error and stop the program
if weight > 50:
    print("Package too heavy to be shipped via Package Express. Have a good day.")
    quit()  # End the program immediately

# Prompt the user for package width
width = float(input("Please enter the package width: "))

# Prompt the user for package height
height = float(input("Please enter the package height: "))

# Prompt the user for package length
length = float(input("Please enter the package length: "))

# Check if the combined dimensions exceed 50
if (width + height + length) > 50:
    print("Package too big to be shipped via Package Express.")
    quit()  # End the program immediately

# If both checks pass, calculate the quote:
# Multiply width * height * length, then multiply by weight, then divide by 100
quote = (width * height * length * weight) / 100

# Display the quote formatted as a dollar amount with 2 decimal places
print(f"Your estimated total for shipping this package is: ${quote:.2f}")
print("Thank you!")
