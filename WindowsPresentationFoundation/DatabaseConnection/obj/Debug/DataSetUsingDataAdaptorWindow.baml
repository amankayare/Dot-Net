   M S B A M L   `   `   `  ����M  IDatabaseConnection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DatabaseConnectionDatabaseConnection  5   	   6    0DatabaseConnection.DataSetUsingDataAdaptorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DatabaseConnection     5   	     � Title$#  DataSetUsingDataAdaptorWindow��5   	   $	��450��6/   $	��800��6<   .��5	      � .+�5
   
   �� -   5         ��Name$ btnFillData��5
      $��	Fill Data��6&   $
��Left=�6:   $��434,117,0,0q�6U   $	��Top=�6j   $	��162��6�    J� RenderTransformOrigin$ 0.042,2.114&�6�   $��35��6�   6�   �� 5   
   -   5        $ btnUpdateData��5      $��Update Data��6(   $
��Left=�6>   $��434,184,0,0q�6Y   $	��Top=�6n   $	��162��6�   $��29��6�   6�   �� 5   
   -   5        $ btnContinueUpdateOnError��5      $��ContinueUpdateOnError��63   $
��Left=�6S   $��434,244,0,0q�6n   $	��Top=�6�   $	��162��6�   $��31��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEmps��5      $
��Left=�6#   $	��313��6>   $��	20,32,0,0q�6K   $	��Top=�6^   $	��387��6v   �� 5   
   -   5        $ btnGetChangedRows��5      $��GetChangedRows��6,   $
��Left=�6E   $��434,298,0,0q�6`   $	��Top=�6u   $	��162��6�   $��31��6�   6�   �� 5   
   -   5        $ btnAcceptChanges��5      $��AcceptChanges��6+   $
��Left=�6C   $��434,345,0,0q�6^   $	��Top=�6s   $	��162��6�   $��30��6�   6�   �� 5   
   -   5        $ btnRejectChanges��5      $��Reject Changes(Undo)��6+   $
��Left=�6J   $��630,117,0,0q�6e   $	��Top=�6z   $	��140��6�   $��35��6�   6�   �� 5   
   -   5        $ 	btnFilter��5      $��Filter��6$   $
��Left=�65   $��630,184,0,0q�6P   $	��Top=�6e   $��39��6}   $��29��6�   6�   �� 5   
   -	   5         ��Name$ 	txtDeptNo��5      $
��Left=�6%   $��29��6@   $��674,184,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $��enter dept no��6u   $	��Top=�6�   $��96��6�   �� 5   
   -
   5        $ btnSaveToFile��5      $��Save To File��6(   $
��Left=�6?   $��630,229,0,0q�6Z   $	��Top=�6o   $	��140��6�   $��26��6�   6�   �� 5   
   -   5        $ btnReadFromFile��5      $��Read From File��6*   $
��Left=�6C   $��630,273,0,0q�6^   $	��Top=�6s   $	��140��6�   $��26��6�   6�   5      5      