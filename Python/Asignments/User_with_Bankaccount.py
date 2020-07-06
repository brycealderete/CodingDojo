class user:
    def __init__(self,name,account="chase"):
        self.name = name 
        self.account = {bankaccount(account)}
    def __repr__(self):
        return f'Name:{self.name}\nBankaccount info:{self.account}'


class bankaccount:
    def __init__(self,account=1,int_rate=.02,balance=0):
        self.int_rate = int_rate
        self.balance = balance
        self.account=account
    def __repr__(self):
        return f'\nAccount name:{self.account_id}\nInterest Rate:{self.int_rate}\nBalance:{self.balance}'
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
    def addbankaccount(self,account="chase"):
        user.account.append(self.account)

        
jim=user('Jim')
bryce= user('Bryce')

Boa=user.account.addbankaccount("Boa")
bryce.account.display_account_info
# bryce.account=(2)


print(bryce.account)
print(jim)