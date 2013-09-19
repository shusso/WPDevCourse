WPDevCourse
===========

Windows Phone development course 2013-2014 Assignments


NOTE:
Running WP emulator in osx w/ fusion requires these changes (shutdown the VM)

### Fusion Configuration for VM
#### Processor&memory:
- increase core amount to 2
- tick enable "hypervisior applications.."

#### Advanced 
- "Preferred virtualization engine" to "Intel VT-x with EPT"

#### Edit the _vmachine_name.vmx file and add
- hypervisor.cpuid.v0 = "FALSE"
- vhv.enable = "TRUE"
- (mce.enable = "TRUE") <== Not sure about this one.

#### Boot VM in fusion
- Start VS with admin rights
- Create test WP project
- build&debug
- emulator should now work :)
