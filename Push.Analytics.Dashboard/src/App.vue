<template>    
    <v-app>
        <div>
            <Header msg="Push Analytics Dashboard V2!" user="AM" />
        </div>
        <v-container style="padding-bottom: 0px!important">
            <v-card>
                <v-toolbar color="deep-purple" dark>
                    <template>
                        <v-tabs fixed-tabs v-model="model" slider-color="grey">
                            <v-tab :key="1" :href="`#tab-1`">
                                Overview
                            </v-tab>
                            <v-tab :key="2" :href="`#tab-2`">
                                Facebook
                            </v-tab>
                            <v-tab :key="3" :href="`#tab-3`">
                                YouTube Live
                            </v-tab>
                            <v-tab :key="4" :href="`#tab-4`">
                                YouTube Vod
                            </v-tab>
                            <v-tab :key="5" :href="`#tab-5`">
                                Titter
                            </v-tab>
                            <v-tab :key="6" :href="`#tab-6`">
                                Twitch
                            </v-tab>
                            <v-tab :key="7" :href="`#tab-7`">
                                Favourite Stats
                            </v-tab>
                        </v-tabs>
                    </template>
                </v-toolbar>
            </v-card>
        </v-container>
        <v-container style="background-color: #14101a !important; ">
            <v-container class="deep-purple" style="padding-top: 0px!important">
                <v-row gutters cols="6" sm="6" md="6" lg="6" xl="6">
                    <v-col cols="12">
                        <v-card class="pa-4" style="background-color: #1a1d21;">
                            <h4 style="">(Red Bull ENG) RBR: Season Launch 2022</h4>
                        </v-card>
                    </v-col>
                </v-row>
            </v-container>
            <v-container class="">
                <v-tabs-items v-model="model">
                    <v-tab-item :key="1" :value="`tab-1`">
                        <v-card>
                            <v-row>
                                <Overview />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="2" :value="`tab-2`">
                        <v-card>
                            <v-row gutters>
                                <FacebookViews title="Facebook Live Views (via web sockets io)" />
                                <v-col gutters sm="6" md="4" lg="4" xl="3" style="background-color:#14101a">
                                    <FacebookReactions :facebookReactions="facebookReactionsData" />
                                    <FacebookDemographic />
                                </v-col>
                            </v-row>
                            <v-row gutters>
                                <FacebookConcurrent title="Facebook Views: Concurrent (via web sockets io & D3)" />
                                <StoryReactions />
                            </v-row>
                            <v-row gutters>
                                <FacebookChatRate title="Facebook Chat Rate (via web sockets io & D3)" />
                                <FacebookImpressions />
                            </v-row>
                            <v-row gutters>
                                <FacebookRetentionGraph /><FacebookGeographic />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="3" :value="`tab-3`">
                        <v-card>
                            <v-row>
                                <YouTubeLiveViews />
                                <YouTubeLiveStats />
                                <YouTubeConcurrent />
                                <YouTubeChatStats />
                                <YouTubeChatRate />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="4" :value="`tab-4`">
                        <v-card>
                            <v-row>
                                <YouTubeViews />
                                <YouTubeDemographic />
                                <YouTubeViews />
                                <YouTubeDevice />
                                <YouTubeDeviceOS />
                                <YouTubeGeographic />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="5" :value="`tab-5`">
                        <v-card>
                            <v-row>
                                <TwitterView />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="6" :value="`tab-6`">
                        <v-card>
                            <v-row>
                                <TwitchView />
                            </v-row>
                        </v-card>
                    </v-tab-item>
                    <v-tab-item :key="7" :value="`tab-7`">
                        <v-card>
                            <v-row>
                            </v-row>
                        </v-card>
                    </v-tab-item>
                </v-tabs-items>

            </v-container>
        </v-container>
    </v-app>
</template>

<script>
    import Overview from './components/Overview.vue';
    import Header from './components/Header.vue';
    import FacebookReactions from './components/FacebookReactions.vue';
    import FacebookViews from './components/FacebookViews.vue';
    import FacebookChatRate from './components/FacebookChatRate.vue';
    import FacebookConcurrent from './components/FacebookConcurrent.vue';    
    import FacebookDemographic from './components/FacebookDemographic.vue';
    import FacebookGeographic from './components/FacebookGeographic.vue';
    import FacebookImpressions from './components/FacebookImpressions.vue';
    import StoryReactions from './components/StoryReactions.vue';
    import FacebookRetentionGraph from './components/RetentionGraph.vue';
    import YouTubeViews from './components/YouTubeViews.vue';
    import YouTubeLiveViews from './components/YouTubeLiveViews.vue';
    import YouTubeLiveStats from './components/YouTubeLiveStats.vue';
    import YouTubeConcurrent from './components/YouTubeConcurrent.vue';
    import YouTubeDemographic from './components/YoutubeDemographic.vue';
    import YouTubeChatStats from './components/YouTubeChatStats.vue';
    import YouTubeChatRate from './components/YouTubeChatRate.vue';
    import YouTubeDeviceOS from './components/YouTubeDeviceOS.vue';
    import YouTubeDevice from './components/YouTubeDevice.vue';
    import YouTubeGeographic from './components/YouTubeGeographic.vue';
    import TwitterView from './components/TwitterView.vue';
    import TwitchView from './components/TwitchView.vue';
    //import Hashids from 'hashids';
    //const hashids = new Hashids("Ly5XJ4WQCnZPS8CdD7Hn", 10);
    //let enc = hashids.encode(121);
    //let dec = hashids.decode(enc)
    //console.log("enc: " + enc + "dec: " + dec)
    //let decode = hashids.decode("jYPwNvw3kL");
    //console.log("my id", decode);
    export default {
        name: 'app',
        components: {
            Overview,
            Header,            
            FacebookReactions,
            FacebookDemographic,
            FacebookGeographic,
            FacebookImpressions,
            FacebookViews,
            FacebookChatRate,
            FacebookConcurrent,
            StoryReactions,
            FacebookRetentionGraph,
            YouTubeViews,
            YouTubeLiveViews,
            YouTubeLiveStats,
            YouTubeDemographic,
            YouTubeConcurrent,
            YouTubeChatStats,
            YouTubeChatRate,
            YouTubeGeographic,
            YouTubeDevice,
            YouTubeDeviceOS,
            TwitterView,
            TwitchView
        },
        data() {
            return {
                facebookReactionsData: [],
                model: 'tab-1'
                /*, Hashids: null*/
            }
        },
        methods: {
            async getReactions() {
                try {
                    const response = await fetch("https://dev.analytics.api.push.live/Facebook/GetFacebookReactionsLatest/614662146495640", {
                            method: 'GET',
                            cache: 'no-cache',                        
                            headers: {
                               'Content-Type': 'application/json'
                            },
                            accept: "*/*"
                        }
                    );
                    //console.log('test response ',response);
                    this.facebookReactionsData = await response.json();
                    //console.log('itmes ', this.items);
                } catch (error) {
                    console.log('Error ', error);
                }    
            }
        },
        watch: {

        },
        created() {
            this.getReactions(); 
        },        
        mounted() {
            // this is when defind hooks 
        }
    }
</script>

<style scoped>
</style>
