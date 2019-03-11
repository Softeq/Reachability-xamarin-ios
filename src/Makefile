XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=./
PROJECT=$(PROJECT_ROOT)/Framework.xcodeproj
TARGET=iOSReachability
OUTPUT=./Output
all: iOSReachability
Build-i386: 
	$(XBUILD) -project $(PROJECT) -scheme $(TARGET) -sdk iphonesimulator -derivedDataPath $(PROJECT_ROOT)/build/386 -configuration Release clean build
iOSReachability-i386: Build-i386
	-mv $(PROJECT_ROOT)/build/386/Build/Products/Release-iphonesimulator/Reachability.framework/Reachability $@
Build-arm64:
	$(XBUILD) -project $(PROJECT) -scheme $(TARGET) -sdk iphoneos -derivedDataPath $(PROJECT_ROOT)/build/64 -arch arm64 -configuration Release clean build 
iOSReachability-arm64: Build-arm64
	-mv $(PROJECT_ROOT)/build/64/Build/Products/Release-iphoneos/Reachability.framework/Reachability $@
Build-armv7:
	$(XBUILD) -project $(PROJECT) -scheme $(TARGET) -sdk iphoneos -derivedDataPath $(PROJECT_ROOT)/build/v7 -arch armv7 -configuration Release clean build 
iOSReachability-armv7: Build-armv7
	-mv $(PROJECT_ROOT)/build/v7/Build/Products/Release-iphoneos/Reachability.framework/Reachability $@
iOSReachability: iOSReachability-i386 iOSReachability-armv7 iOSReachability-arm64
	xcrun -sdk iphoneos lipo -create -output $(OUTPUT)/$@ $^
	-rm -f $^