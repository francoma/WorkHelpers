   M S B A M L   `   `   `  ���� N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  E'clr-namespace:BNACTMFormGenerator.ViewsBNACTMFormGenerator.Views  A%clr-namespace:BNACTMFormGenerator.VMLBNACTMFormGenerator.VML  5    /BNACTMFormGenerator.Views.RelacionOtrosJobsView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :vm+clr-namespace:BNACTMFormGenerator.ViewModel     6vw'clr-namespace:BNACTMFormGenerator.Views     5vml%clr-namespace:BNACTMFormGenerator.VML     .   (BNACTMFormGenerator.VML.ViewModelLocator    AutoHookedUpViewModel  . $	��386��$	��500�� � 	Resources  �� MergedDictionaries �� Source��  �� $! ..\MainWindowResources.xaml?�%    .���  � ColumnDefinitions �� $��* ��� $��* ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$��3��$K��EEl job debe ejecutarse si los siguentes jobs finalizaron exitosamente��$
��Bold"��� $��0��$��1��$��Nombre Job Prod���� $��1��$��1��$��Nombre Job Test���� $��0��$��2��$��2��$	��100������ *JobsEntrada+ �� SelectedItem �� *SelectedJobEntrada+� $��3��$��2��$	��Top=� �� $��* � �� �� .+��� $��0��$��0��$��Agregar Job��$	��Top=����� *AddCommandJobEntrada+�� $��0��$��1��$��
Borrar Job��$	��Top=����� *DeleteCommandJobEntrada+�� $��0��$��4��$��3��$�� ��$
��Bold"��� $��0��$��5��$��3��$T��NSi el job finaliza exitosamente le debe dejar condición a los siguientes jobs��$
��Bold"��� $��0��$��6��$��Nombre Job Prod���� $��1��$��6��$��Nombre Job Test���� $��0��$��7��$��2��$	��100������ *
JobsSalida+ �� *SelectedJobSalida+� $��3��$��7��$	��Top=� �� $��* � �� �� .+��� $��0��$��0��$��Agregar Job������ *AddCommandJobSalida+�� $��1��$��1��$��
Borrar Job������ *DeleteCommandJobSalida+�� $��0��$��8��$��3��$�� ��$
��Bold"��� $��0��$��9��$��3��$J��DEl job no se podrá ejecutar en paralelo con los siguientes procesos��$
��Bold"��� $��0��$��10��$��Nombre Job Prod���� $��1��$��10��$��Nombre Job Test���� $��0��$��11��$��2��$	��100������ *JobsParalelos+ �� *SelectedJobParalelo+� $��3��$��11��$	��Top=� �� $��* � �� �� .+��� $��0��$��0��$��Agregar Job������ *AddCommandJobParalelo+�� $��1��$��1��$��
Borrar Job������ *DeleteCommandJobParalelo+�� $��0��$��12��$��Aclaraciones:���� $��1��$��12��$��4q�$��3��$��2��$
��Left=�$	��250��$��40�� �� TextWrapping$ WrapWithOverflow=� '  #ToolTipWithErrorMessageOnErrorStyle#��[  ���� *Aclaraciones+ �� Mode$ TwoWay=�	 �� ValidatesOnDataErrors	 . 
 �� NotifyOnValidationError
 . 