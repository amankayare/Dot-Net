   M S B A M L   `   `   `  ����M  IDatabaseConnection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DatabaseConnectionDatabaseConnection  5   	   #    DatabaseConnection.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DatabaseConnection     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ txtName��5
      $
��Left=�6#   $��23��6>   $��306,107,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ txtEmpNo��5      $
��Left=�6$   $��23��6?   $��
306,54,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ txtBasic��5      $
��Left=�6$   $��23��6?   $��306,167,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ lblEmpNo��5      $��EmpNo��6"   $
��Left=�62   $��
239,54,0,0q�6M   $	��Top=�6a    J� RenderTransformOrigin$ 
0.832,-3.9&�6y   �� 5   
   -   5        $ lblName��5      $
��Name��6!   $
��Left=�60   $��243,107,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ lblBasic��5      $��Basic��6"   $
��Left=�62   $��251,167,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ 	lblDeptNo��5      $��DeptNo
��6#   $
��Left=�6>   $��243,231,0,0q�6Y   $	��Top=�6n   �� 5   
   -   5        $ 	txtDeptNo��5      $
��Left=�6%   $��23��6@   $��306,231,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��120��6�   �� 5   
   -	   5         ��Name$ 	btnInsert��5      $��Insert��6$   $
��Left=�65   $��251,290,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -
   5        $ 	btnSecure��5      $��Secure Button��6$   $
��Left=�6<   $��468,290,0,0q�6W   $	��Top=�6l   $��94��6�   6�   �� 5   
   -   5        $ btnStoredProcedure��5      $��StoredProcedure Button��6-   $
��Left=�6N   $��357,290,0,0q�6i   $	��Top=�6~   $��94��6�   �� 5   
   -   5        $��Stored Procedure Btn��5      $
��Left=�60   $��585,290,0,0q�6K   $	��Top=�6`   $	��148��6x   6�   �� 5   
   -   5        $ 	btnUpdate��5      $��update��6$   $
��Left=�65   $��156,290,0,0q�6P   $	��Top=�6e   $��75��6}   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��
41,290,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ btnTransaction��5      $��Transaction
��6)   $
��Left=�6I   $��
41,331,0,0q�6d   $	��Top=�6x   $��75��6�   $��22��6�   6�   �� 5   
   -   5        $ btnExecuteScalar��5      $��Execute Scalar��6+   $
��Left=�6D   $��145,331,0,0q�6_   $	��Top=�6t   $��86��6�   6�   5      5      