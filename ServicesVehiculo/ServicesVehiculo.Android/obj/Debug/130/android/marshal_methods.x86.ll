; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [204 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 59
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 88
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 16
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 83
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 73
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 73
	i32 159306688, ; 6: System.ComponentModel.Annotations => 0x97ed3c0 => 99
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 40
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 74
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 38
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 54
	i32 232815796, ; 11: System.Web.Services => 0xde07cb4 => 96
	i32 261689757, ; 12: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 43
	i32 278686392, ; 13: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 58
	i32 280482487, ; 14: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 52
	i32 291275502, ; 15: Microsoft.Extensions.Http.dll => 0x115c82ee => 9
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 30
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 24
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 56
	i32 385762202, ; 19: System.Memory.dll => 0x16fe439a => 23
	i32 441335492, ; 20: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 42
	i32 442521989, ; 21: Xamarin.Essentials => 0x1a605985 => 82
	i32 450948140, ; 22: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 51
	i32 465846621, ; 23: mscorlib => 0x1bc4415d => 15
	i32 469710990, ; 24: System.dll => 0x1bff388e => 22
	i32 476646585, ; 25: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 52
	i32 486930444, ; 26: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 63
	i32 513247710, ; 27: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 13
	i32 526420162, ; 28: System.Transactions.dll => 0x1f6088c2 => 90
	i32 539058512, ; 29: Microsoft.Extensions.Logging => 0x20216150 => 11
	i32 605376203, ; 30: System.IO.Compression.FileSystem => 0x24154ecb => 94
	i32 627609679, ; 31: Xamarin.AndroidX.CustomView => 0x2568904f => 47
	i32 663517072, ; 32: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 79
	i32 666292255, ; 33: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 35
	i32 690569205, ; 34: System.Xml.Linq.dll => 0x29293ff5 => 29
	i32 775507847, ; 35: System.IO.Compression => 0x2e394f87 => 93
	i32 789151979, ; 36: Microsoft.Extensions.Options => 0x2f0980eb => 12
	i32 809851609, ; 37: System.Drawing.Common.dll => 0x30455ad9 => 92
	i32 843511501, ; 38: Xamarin.AndroidX.Print => 0x3246f6cd => 70
	i32 928116545, ; 39: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 88
	i32 955402788, ; 40: Newtonsoft.Json => 0x38f24a24 => 16
	i32 967690846, ; 41: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 56
	i32 974778368, ; 42: FormsViewGroup.dll => 0x3a19f000 => 4
	i32 1012816738, ; 43: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 72
	i32 1028951442, ; 44: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 7
	i32 1035644815, ; 45: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 34
	i32 1042160112, ; 46: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 85
	i32 1052210849, ; 47: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 60
	i32 1098259244, ; 48: System => 0x41761b2c => 22
	i32 1103229598, ; 49: ServicesVehiculo => 0x41c1f29e => 18
	i32 1104002344, ; 50: Plugin.Media => 0x41cdbd28 => 17
	i32 1175144683, ; 51: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 77
	i32 1178241025, ; 52: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 67
	i32 1204270330, ; 53: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 35
	i32 1267360935, ; 54: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 78
	i32 1293217323, ; 55: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 49
	i32 1365406463, ; 56: System.ServiceModel.Internals.dll => 0x516272ff => 97
	i32 1376866003, ; 57: Xamarin.AndroidX.SavedState => 0x52114ed3 => 72
	i32 1395857551, ; 58: Xamarin.AndroidX.Media.dll => 0x5333188f => 64
	i32 1406073936, ; 59: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 44
	i32 1411638395, ; 60: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 26
	i32 1460219004, ; 61: Xamarin.Forms.Xaml => 0x57092c7c => 86
	i32 1462112819, ; 62: System.IO.Compression.dll => 0x57261233 => 93
	i32 1469204771, ; 63: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 33
	i32 1470490898, ; 64: Microsoft.Extensions.Primitives => 0x57a5e912 => 13
	i32 1505131794, ; 65: Microsoft.Extensions.Http => 0x59b67d12 => 9
	i32 1582372066, ; 66: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 48
	i32 1592978981, ; 67: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 68: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 62
	i32 1624863272, ; 69: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 81
	i32 1636350590, ; 70: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 46
	i32 1639515021, ; 71: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 72: System.Runtime => 0x62c6282e => 27
	i32 1658241508, ; 73: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 75
	i32 1658251792, ; 74: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 87
	i32 1670060433, ; 75: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 43
	i32 1719256942, ; 76: ServicesVehiculo.Android.dll => 0x6679c76e => 0
	i32 1729485958, ; 77: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 39
	i32 1766324549, ; 78: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 74
	i32 1770582343, ; 79: Microsoft.Extensions.Logging.dll => 0x6988f147 => 11
	i32 1776026572, ; 80: System.Core.dll => 0x69dc03cc => 20
	i32 1788241197, ; 81: Xamarin.AndroidX.Fragment => 0x6a96652d => 51
	i32 1808609942, ; 82: Xamarin.AndroidX.Loader => 0x6bcd3296 => 62
	i32 1813201214, ; 83: Xamarin.Google.Android.Material => 0x6c13413e => 87
	i32 1818569960, ; 84: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 68
	i32 1828688058, ; 85: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 10
	i32 1867746548, ; 86: Xamarin.Essentials.dll => 0x6f538cf4 => 82
	i32 1878053835, ; 87: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 86
	i32 1885316902, ; 88: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 36
	i32 1919157823, ; 89: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 65
	i32 2011961780, ; 90: System.Buffers.dll => 0x77ec19b4 => 19
	i32 2019465201, ; 91: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 60
	i32 2048185678, ; 92: Plugin.Media.dll => 0x7a14d54e => 17
	i32 2055257422, ; 93: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 57
	i32 2079903147, ; 94: System.Runtime.dll => 0x7bf8cdab => 27
	i32 2090596640, ; 95: System.Numerics.Vectors => 0x7c9bf920 => 25
	i32 2097448633, ; 96: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 53
	i32 2126046302, ; 97: ServicesVehiculo.Android => 0x7eb8e45e => 0
	i32 2126786730, ; 98: Xamarin.Forms.Platform.Android => 0x7ec430aa => 84
	i32 2181898931, ; 99: Microsoft.Extensions.Options.dll => 0x820d22b3 => 12
	i32 2192057212, ; 100: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 10
	i32 2201231467, ; 101: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 102: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 77
	i32 2244775296, ; 103: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 63
	i32 2256548716, ; 104: Xamarin.AndroidX.MultiDex => 0x8680336c => 65
	i32 2261435625, ; 105: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 55
	i32 2266799131, ; 106: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 6
	i32 2279755925, ; 107: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 71
	i32 2315684594, ; 108: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 31
	i32 2317561346, ; 109: ServicesVehiculo.dll => 0x8a232e02 => 18
	i32 2409053734, ; 110: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 69
	i32 2435904999, ; 111: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 100
	i32 2465532216, ; 112: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 42
	i32 2471841756, ; 113: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 114: Java.Interop.dll => 0x93918882 => 5
	i32 2501346920, ; 115: System.Data.DataSetExtensions => 0x95178668 => 91
	i32 2505896520, ; 116: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 59
	i32 2581819634, ; 117: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 78
	i32 2620871830, ; 118: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 46
	i32 2624644809, ; 119: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 50
	i32 2633051222, ; 120: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 58
	i32 2701096212, ; 121: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 75
	i32 2732626843, ; 122: Xamarin.AndroidX.Activity => 0xa2e0939b => 30
	i32 2737747696, ; 123: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 33
	i32 2766581644, ; 124: Xamarin.Forms.Core => 0xa4e6af8c => 83
	i32 2778768386, ; 125: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 80
	i32 2810250172, ; 126: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 44
	i32 2819470561, ; 127: System.Xml.dll => 0xa80db4e1 => 28
	i32 2853208004, ; 128: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 80
	i32 2855708567, ; 129: Xamarin.AndroidX.Transition => 0xaa36a797 => 76
	i32 2903344695, ; 130: System.ComponentModel.Composition => 0xad0d8637 => 95
	i32 2905242038, ; 131: mscorlib.dll => 0xad2a79b6 => 15
	i32 2916838712, ; 132: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 81
	i32 2919462931, ; 133: System.Numerics.Vectors.dll => 0xae037813 => 25
	i32 2921128767, ; 134: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 32
	i32 2978675010, ; 135: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 49
	i32 3024354802, ; 136: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 54
	i32 3044182254, ; 137: FormsViewGroup => 0xb57288ee => 4
	i32 3057625584, ; 138: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 66
	i32 3111772706, ; 139: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3124832203, ; 140: System.Threading.Tasks.Extensions => 0xba4127cb => 98
	i32 3204380047, ; 141: System.Data.dll => 0xbefef58f => 89
	i32 3211777861, ; 142: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 48
	i32 3247949154, ; 143: Mono.Security => 0xc197c562 => 101
	i32 3258312781, ; 144: Xamarin.AndroidX.CardView => 0xc235e84d => 39
	i32 3265893370, ; 145: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 98
	i32 3267021929, ; 146: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 37
	i32 3280506390, ; 147: System.ComponentModel.Annotations.dll => 0xc3888e16 => 99
	i32 3317135071, ; 148: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 47
	i32 3317144872, ; 149: System.Data => 0xc5b79d28 => 89
	i32 3340431453, ; 150: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 36
	i32 3346324047, ; 151: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 67
	i32 3353484488, ; 152: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 53
	i32 3362522851, ; 153: Xamarin.AndroidX.Core => 0xc86c06e3 => 45
	i32 3366347497, ; 154: Java.Interop => 0xc8a662e9 => 5
	i32 3374999561, ; 155: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 71
	i32 3395150330, ; 156: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 26
	i32 3404865022, ; 157: System.ServiceModel.Internals => 0xcaf21dfe => 97
	i32 3428513518, ; 158: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 8
	i32 3429136800, ; 159: System.Xml => 0xcc6479a0 => 28
	i32 3430777524, ; 160: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 161: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 50
	i32 3476120550, ; 162: Mono.Android => 0xcf3163e6 => 14
	i32 3486566296, ; 163: System.Transactions => 0xcfd0c798 => 90
	i32 3493954962, ; 164: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 41
	i32 3501239056, ; 165: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 37
	i32 3509114376, ; 166: System.Xml.Linq => 0xd128d608 => 29
	i32 3536029504, ; 167: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 84
	i32 3567349600, ; 168: System.ComponentModel.Composition.dll => 0xd4a16f60 => 95
	i32 3618140916, ; 169: Xamarin.AndroidX.Preference => 0xd7a872f4 => 69
	i32 3627220390, ; 170: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 70
	i32 3632359727, ; 171: Xamarin.Forms.Platform => 0xd881692f => 85
	i32 3633644679, ; 172: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 32
	i32 3641597786, ; 173: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 57
	i32 3645089577, ; 174: System.ComponentModel.DataAnnotations => 0xd943a729 => 100
	i32 3657292374, ; 175: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 6
	i32 3672681054, ; 176: Mono.Android.dll => 0xdae8aa5e => 14
	i32 3676310014, ; 177: System.Web.Services.dll => 0xdb2009fe => 96
	i32 3682565725, ; 178: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 38
	i32 3684561358, ; 179: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 41
	i32 3689375977, ; 180: System.Drawing.Common => 0xdbe768e9 => 92
	i32 3718780102, ; 181: Xamarin.AndroidX.Annotation => 0xdda814c6 => 31
	i32 3724971120, ; 182: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 66
	i32 3748608112, ; 183: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 21
	i32 3758932259, ; 184: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 55
	i32 3786282454, ; 185: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 40
	i32 3822602673, ; 186: Xamarin.AndroidX.Media => 0xe3d849b1 => 64
	i32 3829621856, ; 187: System.Numerics.dll => 0xe4436460 => 24
	i32 3841636137, ; 188: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 7
	i32 3885922214, ; 189: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 76
	i32 3896760992, ; 190: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 45
	i32 3920810846, ; 191: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 94
	i32 3921031405, ; 192: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 79
	i32 3931092270, ; 193: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 68
	i32 3945713374, ; 194: System.Data.DataSetExtensions.dll => 0xeb2ecede => 91
	i32 3955647286, ; 195: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 34
	i32 4025784931, ; 196: System.Memory => 0xeff49a63 => 23
	i32 4105002889, ; 197: Mono.Security.dll => 0xf4ad5f89 => 101
	i32 4126470640, ; 198: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 8
	i32 4151237749, ; 199: System.Core => 0xf76edc75 => 20
	i32 4182413190, ; 200: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 61
	i32 4213026141, ; 201: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 21
	i32 4260525087, ; 202: System.Buffers => 0xfdf2741f => 19
	i32 4292120959 ; 203: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 61
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [204 x i32] [
	i32 59, i32 88, i32 16, i32 83, i32 73, i32 73, i32 99, i32 40, ; 0..7
	i32 74, i32 38, i32 54, i32 96, i32 43, i32 58, i32 52, i32 9, ; 8..15
	i32 30, i32 24, i32 56, i32 23, i32 42, i32 82, i32 51, i32 15, ; 16..23
	i32 22, i32 52, i32 63, i32 13, i32 90, i32 11, i32 94, i32 47, ; 24..31
	i32 79, i32 35, i32 29, i32 93, i32 12, i32 92, i32 70, i32 88, ; 32..39
	i32 16, i32 56, i32 4, i32 72, i32 7, i32 34, i32 85, i32 60, ; 40..47
	i32 22, i32 18, i32 17, i32 77, i32 67, i32 35, i32 78, i32 49, ; 48..55
	i32 97, i32 72, i32 64, i32 44, i32 26, i32 86, i32 93, i32 33, ; 56..63
	i32 13, i32 9, i32 48, i32 3, i32 62, i32 81, i32 46, i32 2, ; 64..71
	i32 27, i32 75, i32 87, i32 43, i32 0, i32 39, i32 74, i32 11, ; 72..79
	i32 20, i32 51, i32 62, i32 87, i32 68, i32 10, i32 82, i32 86, ; 80..87
	i32 36, i32 65, i32 19, i32 60, i32 17, i32 57, i32 27, i32 25, ; 88..95
	i32 53, i32 0, i32 84, i32 12, i32 10, i32 2, i32 77, i32 63, ; 96..103
	i32 65, i32 55, i32 6, i32 71, i32 31, i32 18, i32 69, i32 100, ; 104..111
	i32 42, i32 1, i32 5, i32 91, i32 59, i32 78, i32 46, i32 50, ; 112..119
	i32 58, i32 75, i32 30, i32 33, i32 83, i32 80, i32 44, i32 28, ; 120..127
	i32 80, i32 76, i32 95, i32 15, i32 81, i32 25, i32 32, i32 49, ; 128..135
	i32 54, i32 4, i32 66, i32 3, i32 98, i32 89, i32 48, i32 101, ; 136..143
	i32 39, i32 98, i32 37, i32 99, i32 47, i32 89, i32 36, i32 67, ; 144..151
	i32 53, i32 45, i32 5, i32 71, i32 26, i32 97, i32 8, i32 28, ; 152..159
	i32 1, i32 50, i32 14, i32 90, i32 41, i32 37, i32 29, i32 84, ; 160..167
	i32 95, i32 69, i32 70, i32 85, i32 32, i32 57, i32 100, i32 6, ; 168..175
	i32 14, i32 96, i32 38, i32 41, i32 92, i32 31, i32 66, i32 21, ; 176..183
	i32 55, i32 40, i32 64, i32 24, i32 7, i32 76, i32 45, i32 94, ; 184..191
	i32 79, i32 68, i32 91, i32 34, i32 23, i32 101, i32 8, i32 20, ; 192..199
	i32 61, i32 21, i32 19, i32 61 ; 200..203
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
