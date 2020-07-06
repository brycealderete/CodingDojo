class Bankaccount:
    def __init__(self,int_rate=10,balance=1000):
        self.int_rate = int_rate
        self.balance = balance
    def __repr__(self):
        return f'Interest Rate:{self.int_rate}\nBalance:{self.balance}'
    def withdraw(self,amount):
        if self.balance<amount:
            print(f"Cannot make withdraw as your balance is less then {amount}")
            return False 
        self.balance = self.balance-amount
        return self
    def deposit(self,amount):
        self.balance +=amount
        return self
    def display_account_info(self):
        print(f'Your interest rate is {self.int_rate}.Your balance is {self.balance}')
    def yeild_interest(self):
        self.balance+= self.balance
        return self

bryce=Bankaccount()
jim=Bankaccount(15,10000)
jim.yeild_interest()
bryce.deposit(489).deposit(489).deposit(489)
jim.withdraw(39).withdraw(39).withdraw(39).withdraw(39).withdraw(39)
bryce.display_account_info()

jim.display_account_info()
