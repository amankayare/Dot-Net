   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   .��5	      � $��Right=�6   $	��792��6'    � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ txtLastName��5      $
��Left=�6'   $��23��6B   $��
85,225,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6w   $	��120��6�   $��1��6�   6�   �� 5   
   -   5        $ txtFirstName��5      $
��Left=�6(   $��23��6C   $��
85,184,0,0q�6O   $
 Wrap=�6c   $	��Top=�6x   $	��120��6�   $��1��6�   6�   �� 5   
   -   5        $ txtFullName��5      $
��Left=�6'   $��23��6B   $��
85,270,0,0q�6N   $
 Wrap=�6b   $	��Top=�6w   $	��120��6�   $��1��6�   �� 5   
   -   5         ��Name$ lblFullName��5      $��	Full Name��6%   $
��Left=�69   $��
13,270,0,0q�6T   $	��Top=�6h   $��67��6�   $��1��6�   $��26��6�   �� 5   
   -   5        $ lblLastName��5      $��	Last Name��6%   $
��Left=�69   $��	8,223,0,0q�6T   $	��Top=�6g    J� RenderTransformOrigin$ -5.235,4.707&�6   $��1��6�   $��26��6�   $��66��6�   5      �� 5   
   -   5        $ lblFirstName��5      $��
First Name��6&   $
��Left=�6;   $��
13,180,0,0q�6V   $	��Top=�6j   $��1��6�   $��26��6�   $��67��6�   �� 5   
   -   5         ��Name$ btnShowFullName��5      $��Show Full Name��6*   $
��Left=�6C   $��
13,331,0,0q�6^   $	��Top=�6r   $	��212��6�   $��1��6�   $��20��6�   5      5      